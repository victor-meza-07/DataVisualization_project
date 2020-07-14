using DataVisualizator.Data.local_models.BST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVisualizator.Data.Services
{
    public class BinaryTreeService
    {
        public BinaryTree Tree { get; set; }
        public BinaryTreeService()
        {
            Tree = new BinaryTree();
        }
    }
}
