using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;

namespace Presentation
{
    public partial class ArbolBi : Form
    {
        private BinaryTree binaryTree;
        public ArbolBi()
        {
            InitializeComponent();
            binaryTree = new BinaryTree(UserLoginCache.FirstName); // El nombre del nodo padre
            panelTree.Paint += new PaintEventHandler(panelTree_Paint);
        }



        private void btnNodo_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            decimal amountTransferred = decimal.Parse(txtTransfers.Text);

            binaryTree.AddOrUpdateNode(userName, amountTransferred);
            panelTree.Invalidate();
        }

        //Orden de Maginutud: O(log n): Logarítmica:  Este método depende de "DrawNode"
        private void panelTree_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int horizontalOffset = 100; // Puedes ajustar este valor según sea necesario
            if (binaryTree.Root != null)
            {
                DrawNode(g, binaryTree.Root, panelTree.Width / 2, 20, horizontalOffset);
            }
        }

        //Orden de Maginutud: O(log n): Logarítmica:  n= número de nodos en el árbol
        private void DrawNode(Graphics g, BinaryTreeNode node, int x, int y, int horizontalOffset)
        {
            if (node == null)
                return;

            int nodeWidth = 80; // Ancho del nodo, puedes ajustar este valor según sea necesario
            int nodeHeight = 40; // Altura del nodo, puedes ajustar este valor según sea necesario

            // Dibuja el rectángulo del nodo
            g.FillRectangle(Brushes.LightBlue, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
            g.DrawRectangle(Pens.Black, x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);

            // Configura el formato de fuente en negrita
            Font nodeFont = new Font("Arial", 10, FontStyle.Bold);

            // Configura el formato de alineación del texto centrado
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            // Dibuja el texto centrado dentro del nodo
            string text = $"{node.UserName}\n{node.TotalAmountTransferred:C}";
            RectangleF textRectangle = new RectangleF(x - nodeWidth / 2, y - nodeHeight / 2, nodeWidth, nodeHeight);
            g.DrawString(text, nodeFont, Brushes.Black, textRectangle, stringFormat);

            // Dibuja las conexiones con los nodos hijos si existen
            if (node.Left != null)
            {
                int childX = x - horizontalOffset;
                int childY = y + 50;
                g.DrawLine(Pens.Black, x, y + nodeHeight / 2, childX, childY - nodeHeight / 2);
                DrawNode(g, node.Left, childX, childY, horizontalOffset / 2);
            }

            if (node.Right != null)
            {
                int childX = x + horizontalOffset;
                int childY = y + 50;
                g.DrawLine(Pens.Black, x, y + nodeHeight / 2, childX, childY - nodeHeight / 2);
                DrawNode(g, node.Right, childX, childY, horizontalOffset / 2);
            }
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
