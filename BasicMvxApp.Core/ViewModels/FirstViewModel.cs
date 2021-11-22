using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMvxApp.Core.ViewModels
{
    /// <summary>
    /// A view model for FirstView.xaml
    /// </summary>
    public class FirstViewModel : MvxViewModel
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FirstViewModel()
        {
        }

        /// <summary>
        /// First method called after construction
        /// </summary>
        public override void Prepare()
        {
        }

        /// <summary>
        /// Overridable async initializer for the view model
        /// </summary>
        /// <returns></returns>
        public override Task Initialize()
        {
            return base.Initialize();
        }

        /// <summary>
        /// An example command for the view model
        /// </summary>
        public IMvxCommand MyFirstCommand => new MvxCommand(MyMethod);

        /// <summary>
        /// A sample method to be invoked with MyFirstCommand
        /// </summary>
        private void MyMethod()
        {
            Text = "Hello MvvmCross";
        }

        /// <summary>
        /// A string property for binding
        /// </summary>
        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
