using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows;
using System.Windows;
namespace Graph
{
    public class Graph
    {
        private Bitmap _graph;

        public Bitmap Graph
        {
            set
            {
                
            }
        }

        public Graph(int height, int width)
        {
            _graph=new Bitmap(height,width);
        }
    }
}
