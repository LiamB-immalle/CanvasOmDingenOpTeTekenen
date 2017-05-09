using CanvasOmDingenOpTeTekenen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanvasOmDingenOpTeTekenen
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            groep.Add(circle1);
            groep.Add(square1);
            groep.Add(t);
        }

        Circle circle1 = new Circle(40, 40);
        Square square1 = new Square(180, 180);
        Triangle t = new Triangle(60, 60);
        List<Shape> groep = new List<Shape>();

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            c.Children.Clear();
            RndPosSquare r = new RndPosSquare();
            r.DisplayOn(c);

            //foreach (Shape shape in groep)
            //{
            //    shape.DisplayOn(c);
            //}
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            c.Children.Clear();
        }
    }
}