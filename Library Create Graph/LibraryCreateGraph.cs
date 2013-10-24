using System;
using System.Collections.Generic;
using System.Drawing;
namespace Library_Create_Graph
{
    public class LibraryCreateGraph
    {

        private readonly Bitmap _graph;

        public Bitmap Graph
        {
            get
            {
                return _graph;
            }
        }

        public LibraryCreateGraph(int height, int width)
        {
            _graph=new Bitmap(height,width);
        }

        void DrawLine(Point point1, Point point2, Color color)
        {
            var deltaX = Math.Abs(point2.X - point1.X);
            var deltaY = Math.Abs(point2.Y - point1.Y);
            var signX = point1.X < point2.X ? 1 : -1;
            var signY = point1.Y < point2.Y ? 1 : -1;
            //
            var error = deltaX - deltaY;
            //
            _graph.SetPixel(point2.X, point2.Y, color);
            while (point1.X != point2.X || point1.Y != point2.Y)
            {
                _graph.SetPixel(point1.X, point1.Y, color);
                var error2 = error * 2;
                //
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    point1.X += signX;
                }
                if (error2 >= deltaX) continue;
                error += deltaX;
                point1.Y += signY;
            }

        }

        private void DrawAxes()
        {
            for (var i = 0; i < _graph.Width; i++)
                _graph.SetPixel(i, _graph.Height/2, Color.Black);
            for (var i = 0; i < _graph.Height; i++)
                _graph.SetPixel(_graph.Width/2, i, Color.Black);
        }

        public void SaveGraph(string filePath)
        {
            _graph.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void CreateGraph(List<Point> values)
        {
            DrawAxes();
            for (var i = 1; i < values.Count; i++)
            {
                DrawLine(values[i-1],values[i],Color.Red);
            }
        }

    }
}
