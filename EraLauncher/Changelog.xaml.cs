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
using System.Windows.Shapes;

namespace EraLauncher
{
    /// <summary>
    /// Logika interakcji dla klasy Changelog.xaml
    /// </summary>
    public partial class Changelog : Page
    {
        public MainWindow MainWindowRef;
        public Changelog()
        {
            InitializeComponent();

            Logs_Content.Text = "- Looting" +
                "- danii put yo changelog here";
        }

    }

    //public static class Test
    //{
       // public static void Update(Changelog Logs_Content)
       // {
       //     Logs_Content.Text = "blah blah, era, we love, matid best developa";
       // }
   // }            //it dosent work at all i think :|

}
