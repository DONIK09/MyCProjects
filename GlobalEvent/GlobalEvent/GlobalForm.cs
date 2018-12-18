using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalEvent
{
    public partial class GlobalForm : Form
    {
        public Counter counter;
        public GlobalForm()
        {
            InitializeComponent();
        }


        private void GlobalForm_Load(object sender, EventArgs e)
        {
            MyHandler handler = new MyHandler();
            this.counter = new Counter(this.listView1);
            this.counter.onCount += handler.Message;
            new Thread(this.counter.Count).Start();
        }
    }
}
