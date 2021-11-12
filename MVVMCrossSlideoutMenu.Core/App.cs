using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MVVMCrossSlideoutMenu.Core.ViewModels;

namespace MVVMCrossSlideoutMenu.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Navigate to this view model on app startup
            RegisterAppStart<FirstViewModel>();

            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
        }
    }
}