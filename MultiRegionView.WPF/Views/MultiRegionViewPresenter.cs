﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Wpf.Views.Presenters;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using System.Threading.Tasks;

namespace MultiRegionView.WPF.Views
{
    public class MultiRegionViewPresenter : MvxWpfViewPresenter
    {

        private readonly ContentControl contentControl;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="_contentControl"></param>
        public MultiRegionViewPresenter(ContentControl _contentControl)
            : base(_contentControl)
        {
            contentControl = _contentControl;
        }

        protected Task<bool> ShowContentView(FrameworkElement element, MvxContentPresentationAttribute attribute, MvxViewModelRequest request)
        {

            // Get the view type to be presented
            var viewType = GetViewType(request);

            // If the view has a region attribute, it's a multi-region view
            if (viewType.HasRegionAttribute())
            {

                // 
                var loader = Mvx.IoCProvider.Resolve<IMvxWpfViewLoader>();
                
                
                var view = loader.CreateView(request);

                var containerView = FindChild<Frame>(contentControl, viewType.GetRegionName());

                if (containerView != null)
                {
                    containerView.Navigate(view);
                }
            }
        }


        private static Type GetViewType(MvxViewModelRequest request)
        {
            // get views
            var viewFinder = Mvx.IoCProvider.Resolve<IMvxViewsContainer>();

            //
            return viewFinder.GetViewType(request.ViewModelType);
        }

        ///// <summary>
        ///// Changes the presenter when invoked
        ///// </summary>
        ///// <param name="hint">A hint about how the next view should be displayed</param>
        //public override void ChangePresentation(MvxPresentationHint hint)
        //{
        //    // deal with popToRoot
        //    base.ChangePresentation(hint);
        //}


        internal static T FindChild<T>(DependencyObject reference, string childName) where T : DependencyObject
        {
            // Confirm parent and childName are valid.
            if (reference == null) return null;

            var foundChild = default(T);
            var nextPhase = new List<DependencyObject>();

            var childrenCount = VisualTreeHelper.GetChildrenCount(reference);
            for (var index = 0; index < childrenCount; index++)
            {
                var child = VisualTreeHelper.GetChild(reference, index);

                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                    else
                    {
                        // keep for searching inside this frame
                        nextPhase.Add(child);
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            // if failed to find the child, search inside the frames we found
            if (foundChild == null)
            {
                foreach (var item in nextPhase)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(item, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;

                }
            }

            return foundChild;
        }




    }
}