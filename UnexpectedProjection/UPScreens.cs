﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnexpectedProjection
{

    public class UPScreen
    {
        public Screen WindowsScreen;

        public UPScreen(Screen s)
        {
            WindowsScreen = s;
        }

        public override string ToString()
        {
            if (WindowsScreen == null)
                return "Project to a Window Named 'UPPrj'";

            string strS = "\"" + WindowsScreen.DeviceName + "\" (" + WindowsScreen.Bounds.ToString() + ")";
            if (WindowsScreen.Primary)
                strS += "[P]";

            return strS;
        }
    }

    public class UPScreens
    {
        private List<UPScreen> m_screens;
        public UPScreens()
        {
            m_screens = new List<UPScreen>(Screen.AllScreens.Length);
            m_screens.Add(new UPScreen(null));
            foreach (var s in Screen.AllScreens)
            {
                m_screens.Add(new UPScreen(s));
            }
        }

        public List<UPScreen> Screens
        {
            get { return m_screens; }
        }


 
    }

}