using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MVVMCrossSlideoutMenu
{
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            // register the setup class
            this.RegisterSetupType<Setup>();
        }
    }
}
