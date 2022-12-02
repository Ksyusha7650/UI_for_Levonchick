using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public interface IMainWindow
    {
       event EventHandler<EventArgs> OpenAbout;
       event EventHandler<EventArgs> Exit;
    }
}
