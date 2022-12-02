using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Presenter
    {
        private IMainWindow _main;

        public Presenter(IMainWindow main)
        {
            _main = main;
            _main.OpenAbout += ShowInfo;
            _main.Exit += CloseApp;
        }

        public void CloseApp(Object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void ShowInfo(Object sender, EventArgs e)
        {
           new WindowAbout().ShowDialog();
        } 
    }
}
