using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisokInterface
{
    class Element:IComparable<Element>
    {
        public virtual int CompareTo(Element other) { return 0; }
        public virtual void changeData(object e) { }
        public virtual object getData() { return null; }
     }
}
