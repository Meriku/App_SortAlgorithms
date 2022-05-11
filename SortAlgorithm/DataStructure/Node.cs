using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.DataStructure
{
    public class Node
    {
        public int Data { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public Node(int data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public void Add(Node node)
        {

            if (node.Data < Data)         // Если новый элемент меньше чем текущий -> добавляем влево
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(node);
                }
            }
            else                    // Иначе -> добавляем вправо
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(node);
                }
            }
        }
    }
}
 

