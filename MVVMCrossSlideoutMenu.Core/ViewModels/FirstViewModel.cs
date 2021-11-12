﻿using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCrossSlideoutMenu.Core.ViewModels
{
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
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}