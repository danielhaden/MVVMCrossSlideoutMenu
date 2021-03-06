using BasicMvxApp.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;

namespace BasicMvxApp.WPF.Views
{
    /// <summary>
    /// Interaction logic for FirstView.xaml
    /// </summary>
    [MvxContentPresentation] // Sets this view as a *content*
    [MvxViewFor(typeof(FirstViewModel))] // Sets FirstViewModel as the View Model for this View
    public partial class FirstView : MvxWpfView
    {
        public FirstView()
        {
            InitializeComponent();
        }
    }
}
