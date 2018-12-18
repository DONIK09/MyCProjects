using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokInterface
{
    class MyString:Element
    {
        public string Data { get; set; }
        public MyString(string Data) { this.Data = Data; }
        public override object getData(){ return this.Data; }
        public override string ToString()
        {
            return this.Data;
        }
        public override void changeData(object e)
        {
            if (e is string &&!( double.TryParse((string)e,out double a)))
            {
                this.Data = (string)e;
            }
            else
            {
                MessageBox.Show(e + " является числом!");
            }
        }

        public override int CompareTo(Element other)
        {
            return this.Data.CompareTo(other.getData().ToString());
        }
    }
}
