using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalEvent
{
    public class Counter
    {
        public ListView listView;

        public Counter(ListView listView)
        {
            this.listView = listView;

        }
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void Count()
        {
            for(int i = 0;i < 15; i++)
            {
                Thread.Sleep(1000);
                this.listView.Items.Add(i.ToString());
                if(i == 10)
                {
                    this.onCount();
                }
            }
        }
    }
}
