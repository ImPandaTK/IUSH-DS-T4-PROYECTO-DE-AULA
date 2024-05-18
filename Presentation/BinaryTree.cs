using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; }

        public BinaryTree(string userName)
        {
            Root = new BinaryTreeNode(userName, 0); // Nodo padre
        }



        public void AddOrUpdateNode(string userName, decimal amountTransferred)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(userName, amountTransferred);
                return;
            }

            AddOrUpdateNodeRecursive(Root, userName, amountTransferred);
        }

        private void AddOrUpdateNodeRecursive(BinaryTreeNode parentNode, string userName, decimal amountTransferred)
        {
            if (parentNode.UserName == userName)
            {
                // Si el nodo ya existe, simplemente actualiza su cantidad transferida
                parentNode.AmountTransferred += amountTransferred;
                return;
            }

            if (parentNode.Left != null)
            {
                AddOrUpdateNodeRecursive(parentNode.Left, userName, amountTransferred);
            }
            else
            {
                parentNode.Left = new BinaryTreeNode(userName, amountTransferred);
                return;
            }

            if (parentNode.Middle != null)
            {
                AddOrUpdateNodeRecursive(parentNode.Middle, userName, amountTransferred);
            }
            else
            {
                parentNode.Middle = new BinaryTreeNode(userName, amountTransferred);
                return;
            }

            if (parentNode.Right != null)
            {
                AddOrUpdateNodeRecursive(parentNode.Right, userName, amountTransferred);
            }
            else
            {
                parentNode.Right = new BinaryTreeNode(userName, amountTransferred);
                return;
            }
        }
    }

}
