using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace CanvasOmDingenOpTeTekenen
{
    public class Square : Shape
    {
        protected Rectangle rect;

        public Square(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateRectangle();
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(rect);
        }

        protected void CreateRectangle()
        {
            rect = new Rectangle();
            rect.Stroke = brush;
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(x, y, 0, 0);
        }
    }
}