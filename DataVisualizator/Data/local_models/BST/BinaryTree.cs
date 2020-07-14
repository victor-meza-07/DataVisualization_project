using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataVisualizator.Data.local_models.BST
{
    public class BinaryTree
    {
        public Node RootNode { get; set; }
        public BinaryTree()
        {
            RootNode = new Node();
        }



        public Node Search(int i) 
        {

            if (i == RootNode.Value)
            {
                //we found it! first time
                return RootNode;
            }
            else 
            {
                //we couldn't find it :(
            }
            return null;
        }
        private Node Search(int i, Node root) 
        {
            return null;
        }

        public void Add(Node node) 
        {
            if (RootNode.Value == null)
            {
                RootNode.Value = node.Value;
                RootNode.Generation = 0;
            }
            else 
            {
                Add(node, RootNode);
            }
        }
        private void Add(Node node, Node currentRoot) 
        {
            if (node.Value > currentRoot.Value)
            {
                if (currentRoot.RightChild == null) 
                {
                    currentRoot.RightChild = node;
                    currentRoot.RightChild.Generation = currentRoot.Generation + 1;
                }
                else 
                {
                    Add(node,currentRoot.RightChild);
                }
            }
            else 
            {
                if (currentRoot.LeftChild == null) 
                {
                    currentRoot.LeftChild = node;
                    currentRoot.LeftChild.Generation = currentRoot.Generation + 1;
                }
                else 
                {
                    Add(node, currentRoot.LeftChild);
                }
            }
        }

    }
}
