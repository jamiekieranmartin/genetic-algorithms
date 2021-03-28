using System.Collections.Generic;
using System.Reactive;
using ReactiveUI;
using System;
using System.Linq;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace ScheduleView
{
    public class EventImage
    {
        public string EventInfo { get; set; }
        public int AgeGroup { get; set; }
        public int StartTime { get; set; }
        public int Duration { get; set; }
        public string EventColourCode { get; set; }
    }

    public class TimePoint
    {
        public int label { get; set; }
        public int position { get; set; }
        public int labelPosition {  get { return position - 12; } }
    }

    public class AgeGroup
    {
        public string Name { get; set; }
        public int Index { get; set; }
    }

    public class AppViewModel : ReactiveObject
    {
        bool cancel = false;
        Task backgroundTask = null;

        private string GAEngine = "FSharp";
        public ReactiveUI.ReactiveCommand<Unit, Unit> CSharpCommand { get; private set; }
        public ReactiveUI.ReactiveCommand<Unit, Unit> FSharpCommand { get; private set; }

        [Reactive]
        public string SolutionStatus { get; set; }

        [Reactive]
        public IEnumerable<AgeGroup> AgeGroups { get; set; }

        [Reactive]
        public IEnumerable<EventImage> BestSchedule { get; set; }

        [Reactive]
        public IEnumerable<TimePoint> TimeLines { get; set; }      

        private string EventColourCode(string eventName)
        {
            switch (eventName)
            {
                case "70m Sprint":  
                    return "#ff0000";
                case "100m Sprint": 
                    return "#f5001e";
                case "200m Sprint": 
                    return "#eb003c";
                case "400m Run":    
                    return "#d70078";
                case "800m Run":    
                    return "#c300b4";
                case "1500m Run":   
                    return "#b900d2";
                case "Discus":      
                    return "#00ff00";
                case "Shot Put":    
                    return "#28d700";
                case "Javelin":     
                    return "#50af00";
                case "Long Jump":   
                    return "#00ffff";
                case "Triple Jump": 
                    return "#28d7ff";
                case "High Jump":   
                    return "#7887ff";
                case "300m Run":
                    return "#e1005a";
                case "500m Run":
                    return "#cd0096";
                case "700m Run":
                    return "#cd00aa";
                case "Game":
                    return "#c8c8c8";
                case "Vortex":
                    return "#c8c8c8";
                case "Turbo Jav":
                    return "#c8c8c8";
                case "200m Hurdles (68cm)":
                    return "#ffff8c";
                case "200m Hurdles (76cm)":
                    return "#ffffa0";
                case "300m Hurdles (76cm)":
                    return "#ffffb4";
                case "110m Hurdles (76cm)":
                    return "#ffff82";
                case "100m Hurdles (76cm)":
                    return "#ffff78";
                case "90m Hurdles (76cm)":
                    return "#ffff64";
                case "80m Hurdles (76cm)":
                    return "#ffff50";
                case "80m Hurdles (68cm)":
                    return "#ffff46";
                case "80m Hurdles (60cm)":
                    return "#ffff41";
                case "60m Hurdles (68cm)":
                    return "#ffff3c";
                case "60m Hurdles (60cm)":
                    return "#ffff28";
                case "60m Hurdles (45cm)":
                    return "#ffff14";
                case "60m Hurdles (30cm)":
                    return "#ffff0a";
                case "60m Hurdles (20cm)":
                    return "#ffff05";
                case "60m Hurdles (pipe)":
                    return "#ffff00";
                case "300m Walk":
                    return "#ff00ff";
                case "700m Walk":
                    return "#ff28ff";
                case "1100m Walk":
                    return "#ff50ff";
                case "1500m Walk":
                    return "#ff78ff";
                case "High Jump (scissors)":
                    return "#50afff";
                default:  
                    return "#000000";
            }
        }

        private int AgeIndexScale(int index)
        {
            return 40 + index * 30;
        }

        private int TimeScale(int minutes)
        {
            return minutes * 20;
        }

        private Schedule.Event[] ReadEvents(string filename)
        {
            var eventList = new List<Schedule.Event>();

            using (var reader = new System.IO.StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var parts = line.Split(',');
                    var ageGroup = parts[0];
                    var eventName = parts[1];
                    var duration = int.Parse(parts[2]);
                    var location = parts[3];

                    eventList.Add(new Schedule.Event(eventName, ageGroup, location, duration));
                }
            }

            return eventList.ToArray();
        }

        private double shortest;
        private DateTime lastUpdate;

        public void OnNewSolution(System.Tuple<int[],double> solution, Schedule.Event[] events)
        {
            var length = -solution.Item2;

            // Is this better than the previous solution?
            if (length < shortest)
            {
                shortest = length;
                System.Diagnostics.Trace.TraceInformation("best time {0}", shortest);

                var schedule = Schedule.schedule(events, solution.Item1);
                var show = schedule.Select(evnt => new EventImage { EventInfo = evnt.@event.eventName + ":" + evnt.allocated, StartTime = 100 + TimeScale(evnt.startTime), AgeGroup = AgeIndexScale(ageGroups.IndexOf(evnt.@event.ageGroup)), Duration = TimeScale(evnt.finishTime - evnt.startTime), EventColourCode = EventColourCode(evnt.@event.eventName) });

                if (App.Current != null)
                    // Perform update on the UI thread ...
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        BestSchedule = show;
                        SolutionStatus = String.Format("Best finish time: {0:0.} minutes", length);
                    });
            }
        }

        private void DisplaySolutionsAsGenerated(IEnumerable<System.Tuple<int[], double>> solutions, Schedule.Event[] events )
        {
            shortest = Double.MaxValue;

            foreach (var solution in solutions)
            {
                if (cancel)
                    break;
                OnNewSolution(solution, events);
            }
        }

        List<string> ageGroups;

        private IEnumerable<AgeGroup> getAgeGroups(Schedule.Event[] events)
        {
            ageGroups = events.Select(e => e.ageGroup).Distinct().OrderBy(a => a).ToList();
            return ageGroups.Select((ageGroup, index) => new AgeGroup { Name = ageGroup, Index = AgeIndexScale(index) });
        }

        private void CancelPreviousProblem()
        {
            if (backgroundTask != null)
            {
                cancel = true;
                backgroundTask.Wait();
            }

            cancel = false;
        }

        string lastFilename = null;

        public void Open(string filename)
        {
            CancelPreviousProblem();

            BestSchedule = new EventImage[0];
            SolutionStatus = "";

            var events = ReadEvents(filename);

            AgeGroups = getAgeGroups(events);

            var numberOfIndividuals = 10;

            IEnumerable<System.Tuple<int[], double>> solutions;

            var fitnessFunction = Schedule.athleticsScheduleCost(events);

            if (GAEngine == "FSharp")
                solutions = CAB402.FSharp.GeneticAlgorithm.Optimize(fitnessFunction, events.Length, numberOfIndividuals);
            else
                solutions = CAB402.CSharp.GeneticAlgorithm.Optimize(fitnessFunction, events.Length, numberOfIndividuals);

            backgroundTask = Task.Run(() => DisplaySolutionsAsGenerated(solutions, events));
        }

        public AppViewModel()
        {
            TimeLines = Enumerable.Range(0, 20).Select(period => new TimePoint { label = period * 30, position = 100 + TimeScale(period * 30) }).ToList();

            CSharpCommand = ReactiveCommand.Create(new Action(() => { this.GAEngine = "CSharp"; }));
            FSharpCommand = ReactiveCommand.Create(new Action(() => { this.GAEngine = "FSharp"; }));
        }
    }
}
