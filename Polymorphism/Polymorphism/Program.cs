using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> Polygons = new List<Polygon>();
            Polygons.Add(new Polygon());
            Polygons.Add(new Rectangle());
            Polygons.Add(new Triangle());

            foreach (Polygon item in Polygons)
            {
                item.Draw();
            }

            Triangle Triangle1 = new Triangle();
            Triangle1.Draw();

            
        }
    }

    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Polygon.");
        }
    }

    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    class Triangle : Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
    }

}
