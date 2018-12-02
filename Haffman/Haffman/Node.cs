using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haffman
{
    class Node
    {
        public byte? data { get; set; } = null;
        public int weight { get; set; }
        public Node left { get; set; } = null;
        public Node right { get; set; } = null;
        public Node(byte data)
        {
            this.data = data;
        }
        public Node(Node left,Node right)
        {
            this.left = left;
            this.right = right;
            this.weight = left.weight + right.weight;
        }
    }
}
