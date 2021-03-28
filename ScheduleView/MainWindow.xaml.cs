using System.Windows;
using ReactiveUI;
using Microsoft.Win32;

namespace ScheduleView
{
    public partial class MainWindow : ReactiveWindow<AppViewModel>
    {
        public MainWindow()
        {
            ViewModel = new AppViewModel();

            InitializeComponent();

            this.WhenActivated(disposable =>
            {
                this.OneWayBind(this.ViewModel, vm => vm.BestSchedule, v => v.BestSchedule.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.AgeGroups, v => v.AgeGroups.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.TimeLines, v => v.TimeLines.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.TimeLines, v => v.TimeLinesLabels.ItemsSource);
                this.OneWayBind(this.ViewModel, vm => vm.SolutionStatus, v => v.SolutionStatus.Content);
                this.BindCommand(this.ViewModel, vm => vm.CSharpCommand, v => v.CSharp);
                this.BindCommand(this.ViewModel, vm => vm.FSharpCommand, v => v.FSharp);
            });
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
                ViewModel.Open(dialog.FileName);
        }
    }
}
