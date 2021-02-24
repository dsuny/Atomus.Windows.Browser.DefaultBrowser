using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Atomus.Windows.Browser
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //this.Run(new DefaultBrowser());
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //this.StartupUri = new Uri("DefaultBrowser.xaml", UriKind.Relative);
        }
    }
}