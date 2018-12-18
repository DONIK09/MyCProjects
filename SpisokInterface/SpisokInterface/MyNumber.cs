using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokInterface
{
    class MyNumber : Element
    {
        public double Data { get; set; }

        public MyNumber(double Data) { this.Data = Data; }
        public override object getData() { return this.Data; }
        public override string ToString()
        {
            return this.Data.ToString();
        }
        public override void changeData(object e)
        {
            if (double.TryParse((string)e, out double result))
            {
                this.Data = result;
            }
            else
            {
                MessageBox.Show(e + " не является числом!");
            }
        }
        public override int CompareTo(Element other)
        {
            return this.Data.ToString().CompareTo(other.getData().ToString());
        }
    }
}

