using MultiRegionView.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;

namespace MultiRegionView.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    [MvxContentPresentation] // Sets this view as a *content*
    [MvxViewFor(typeof(MainViewModel))]
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
