﻿using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "buttonTrace":
                    Logger.Trace("This is a sample trace message");
                    break;
                case "buttonDebug":
                    Logger.Debug("This is a sample debug message");
                    break;
                case "buttonInfo":
                    Logger.Info("This is a sample info message");
                    break;
                case "buttonWarn":
                    Logger.Warn("This is a sample warn message");
                    break;
                case "buttonError":
                    Logger.Error("This is a sample error message");
                    break;
                case "buttonFatal":
                    Logger.Fatal("This is a sample fatal message");
                    break;
                default:
                    throw new InvalidOperationException(String.Format("Button name '{0}' is not supported", btn.Name));
            }
        }
    }
}