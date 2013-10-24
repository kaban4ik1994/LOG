using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CreateGraph
{
    public class CreateGraph
    {
        private Bitmap _graph;

        public CreateGraph(int height, int width)
        {
            _graph=new Bitmap(height,width);
        }


    }
}
