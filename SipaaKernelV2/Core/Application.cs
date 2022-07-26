﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;
using SipaaKernelV2.UI;

namespace SipaaKernelV2.Core
{
    internal class Application
    {
        public View CurrentView;
        public string ApplicationName, ApplicationDeveloper;
        public double ApplicationVersion;

        public void SetCurrentView(View view)
        {
            if (view == null) return;
            CurrentView = view;
            view.OnViewOpened();
        }

        public void Update()
        {
            CurrentView.Update();
        }
        public void Draw(Canvas c)
        {
            CurrentView.Draw(c);
        }
    }
}
