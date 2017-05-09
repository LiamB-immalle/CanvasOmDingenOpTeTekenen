using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CanvasOmDingenOpTeTekenen
{
    class Triangle : Shape
    {
        private Polygon tria;

        public Triangle(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateTriangle();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(tria);
        }

        private void CreateTriangle()
        {
            tria = new Polygon();
            tria.Stroke = brush;
            tria.Margin = new Thickness(x, y, 0, 0);
            tria.Points = new PointCollection() { new Point(x, y), new Point(x, y+100), new Point(x+100, y) };
        }
    }
}