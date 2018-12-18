using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalEvent
{
    public class MyHandler
    {
        public MyHandler() { }
        public void Message()
        {
            MessageBox.Show("Счётчик дошёл до 10!");
        }
    }
}
