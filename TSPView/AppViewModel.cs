using System.Reactive;
using System.Collections.Generic;
using ReactiveUI;
using System;
using System.Linq;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace TSPView
{
    public class Location
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Segment
    {
        public TSP.City From { get; set; }
        public TSP.City To { get; set; }
    }

    public class AppViewModel : ReactiveObject
    {
        [Reactive]
        public string SolutionStatus { get; set; }

        [Reactive]
        public IList<Segment> BestTour { get; set; }

        [Reactive]
        public IEnumerable<Location> Locations { get; set; }

        public ReactiveUI.ReactiveCommand<Unit, Unit> NewCommand { get; private set; }
        public ReactiveUI.ReactiveCommand<Unit, Unit> CSharpCommand { get; private set; }
        public ReactiveUI.ReactiveCommand<Unit, Unit> FSharpCommand { get; private set; }

        private void CancelProblem()
        {
            if (backgroundTask != null)
            {
                cancel = true;
                backgroundTask.Wait();
            }
        }

        private string GAEngine = "FSharp";

        private void StartNewProblem(System.Random random)
        {
            CancelProblem();

            var cities = RandomMonad.evaluateWith(random, TSP.generateRandomCities(100));
            Locations = cities.Select(city => new Location { Top = city.y - 3, Left = city.x - 3, Width = 6, Height = 6});

            BestTour = new List<Segment>();

            var fitnessFunction = TSP.TSPCost(cities);
            var numberOfIndividuals = 100;

            IEnumerable<Tuple<int[], double>> solutions;

            if (GAEngine == "FSharp")
                solutions = CAB402.FSharp.GeneticAlgorithm.Optimize(fitnessFunction, cities.Length, numberOfIndividuals);
            else 
                solutions = CAB402.CSharp.GeneticAlgorithm.Optimize(fitnessFunction, cities.Length, numberOfIndividuals);

            double shortestTour = double.MaxValue;

            var start = System.DateTime.Now;

            cancel = false;

            backgroundTask = Task.Run(() =>
            {
                foreach (var solution in solutions)
                {
                    if (cancel)
                        break;

                    var tourLength = -solution.Item2;

                    if (tourLength < shortestTour)
                    {
                        shortestTour = tourLength;
                        var orderedCities = solution.Item1.Select(i => cities[i]).ToList();

                        var tour = new List<Segment>();
                        for (int i = 0; i < orderedCities.Count() - 1; i++)
                            tour.Add(new Segment { From = orderedCities[i], To = orderedCities[i + 1] });
                        tour.Add(new Segment { From = orderedCities.Last(), To = orderedCities.First() });

                        var status = String.Format("Best tour length: {0:0.0}", tourLength);

                        // Update on UI thread ...
                        if (App.Current != null && !cancel)
                            App.Current.Dispatcher.Invoke(() =>
                            {
                                BestTour = tour;
                                SolutionStatus = status;
                            });

                        System.Threading.Thread.Sleep(100); // Don't overwhelm the UI  thread
                    }
                }
            });
        }

        bool cancel = false;
        Task backgroundTask = null;

        public AppViewModel()
        {
            NewCommand = ReactiveCommand.Create(new Action(() => this.StartNewProblem(new System.Random())));
            CSharpCommand = ReactiveCommand.Create(new Action(() => { this.GAEngine = "CSharp"; this.StartNewProblem(new System.Random()); }));
            FSharpCommand = ReactiveCommand.Create(new Action(() => { this.GAEngine = "FSharp"; this.StartNewProblem(new System.Random()); }));

            StartNewProblem(new System.Random(42));
        }
    }
}
