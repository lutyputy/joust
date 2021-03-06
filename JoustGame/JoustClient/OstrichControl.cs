﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using JoustModel;

namespace JoustClient
{
    public class OstrichControl : WorldObjectControl
    {
        public OstrichControl(string imagePath) : base(imagePath)
        {
            Height = 75;
            Width = 50;
        }

        public void NotifyMoved(object sender, int e)
        {
            Ostrich o = sender as Ostrich;
            Canvas.SetTop(this, o.coords.y);
            Canvas.SetLeft(this, o.coords.x);
        }
    }
}
