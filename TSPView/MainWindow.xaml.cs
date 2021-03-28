using System.Windows;
using ReactiveUI;

namespace TSPView
{
    public partial class MainWindow : ReactiveWindow<AppViewModel>
    {
        public MainWindow()
        {
            ViewModel = new AppViewModel();

            InitializeComponent();

            this.WhenActivated(disposable =>
            { 
                this.OneWayBind(this.ViewModel, vm => vm.BestTour, v => v.BestTour.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.Locations, v => v.Locations.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.SolutionStatus, v => v.SolutionStatus.Content);
                this.BindCommand(this.ViewModel, vm => vm.NewCommand, v => v.New);
                this.BindCommand(this.ViewModel, vm => vm.CSharpCommand, v => v.CSharp);
                this.BindCommand(this.ViewModel, vm => vm.FSharpCommand, v => v.FSharp);
            });
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
