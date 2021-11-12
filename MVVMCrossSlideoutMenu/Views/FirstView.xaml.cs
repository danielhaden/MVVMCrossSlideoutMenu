using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MVVMCrossSlideoutMenu.Core.ViewModels;

namespace MVVMCrossSlideoutMenu.WPF.Views
{
    /// <summary>
    /// Interaction logic for FirstView.xaml
    /// </summary>
    [MvxContentPresentation] // Present the content of this view
    [MvxViewFor(typeof(FirstViewModel))] // Set the view model for this view
    public partial class FirstView : MvxWpfView
    {
        public FirstView()
        {
            InitializeComponent();
        }
    }
}
