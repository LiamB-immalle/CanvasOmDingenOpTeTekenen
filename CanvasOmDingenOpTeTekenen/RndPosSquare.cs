using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;

namespace CanvasOmDingenOpTeTekenen
{
    class RndPosSquare : Square
    {
        static Random rndGen = new Random();


        public RndPosSquare() : base(rndGen.Next(1, 150), rndGen.Next(1, 150))
        {           
        }

        public override void DisplayOn(Canvas drawArea)
        {
            //Made CreateRectangle() and "Rectangle rect" protected in Square class
            CreateRectangle();
            base.DisplayOn(drawArea);
        }
    }
}