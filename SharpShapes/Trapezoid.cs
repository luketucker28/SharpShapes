using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Trapezoid : Shape
    {
        public Trapezoid(int p1, int p2, int p3)
        {
        }

        public object LongBase { get; set; }

        public object ShortBase { get; set; }

        public object Height { get; set; }

        public object ObtuseAngle { get; set; }

        public object AcuteAngle { get; set; }

        public override void Scale(int percent)
        {
            throw new NotImplementedException();
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }

        public override int SidesCount
        {
            get { throw new NotImplementedException();  }
        }
    }
}
