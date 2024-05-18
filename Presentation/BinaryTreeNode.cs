using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class BinaryTreeNode
    {
        public string UserName { get; set; }
        public decimal AmountTransferred { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode Middle { get; set; }
        public decimal TotalAmountTransferred { get; set; }

        public BinaryTreeNode(string userName, decimal amountTransferred)
        {
            UserName = userName;
            AmountTransferred = amountTransferred;
            Left = null;
            Right = null;
            Middle = null;
        }
    }
}
