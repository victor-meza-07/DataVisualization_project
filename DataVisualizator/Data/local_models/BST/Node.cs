using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVisualizator.Data.local_models.BST
{
    public class Node
    {
        public int? Value { get; set; }
        public int? Generation { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}
