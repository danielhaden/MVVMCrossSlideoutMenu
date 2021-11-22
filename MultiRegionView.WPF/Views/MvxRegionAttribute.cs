﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiRegionView.WPF.Views
{

    /// <summary>
    /// Custom attribute for designating a region.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class MvxRegionAttribute
        : Attribute
    {
        public MvxRegionAttribute(string regionName)
        {
            this.Name = regionName;
        }

        public string Name { get; private set; }
    }
}