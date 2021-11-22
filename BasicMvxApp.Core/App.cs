using BasicMvxApp.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace BasicMvxApp.Core
{
    public class App : MvxApplication
    {
        // Perform initialization steps on app startup
        public override void Initialize()
        {
            CreatableTypes() // Find all classes in the Core assembly which are creatable (i.e. aren't abstract and have a public constructor)
                .EndingWith("Service") // which have a name ending in "Service"
                .AsInterfaces() // Find their interfaces
                .RegisterAsLazySingleton(); // Register them as lazy singletons (i.e. they are instantiated when they are first accessed)

            // Navigate to this view model on app startup
            RegisterAppStart<FirstViewModel>();

            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
        }
    }
}