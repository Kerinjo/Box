using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    enum UnitOfMeasure
    {
        Milimeter,
        Centimeter,
        Meter
    }
    internal class Box
    {
        public double width
        {
            get => _width;
            set => _width = Math.Round(value, 3);
        }
        private double _width;

        public double length
        {
            get => _length;
            set => _length = Math.Round(value, 3);
        }
        private double _length;
        
        public double height
        {
            get => _height;
            set => _height = Math.Round(value, 3);
        }
        private double _height;

        public UnitOfMeasure measure;

        public Box(double width = 10, double length = 10, double height = 10, UnitOfMeasure measure = UnitOfMeasure.Meter)
        {
            if (width < 0 || length < 0 || height < 0)
                throw new ArgumentOutOfRangeException("Box measures out of range: negative value");

            if (measure == UnitOfMeasure.Meter && (width > 10 || length > 10 || height > 10) ||
                measure == UnitOfMeasure.Centimeter && (width > 100 || length > 100 || height > 100) ||
                measure == UnitOfMeasure.Milimeter && (width > 1000 || length > 1000 || height > 1000))
            {
                throw new ArgumentOutOfRangeException("Box measures out of range: over 10 meters");
            }

            this.width = width;
            this.length = length;
            this.height = height;
            this.measure = measure;
        }

        // domyslnie wypisywac w metrach
        public override string ToString()
        {
            // TODO: dokladnosc 3 miejsc
            string returnString = $"{width} {measure} \u00D7 {length} {measure} \u00D7 {height} {measure}";
            return returnString;
        }

        public string ToString(string format)
        {
            if (format == "m")
            {
                // dokladnosc 3 miejsc po przecinku
            }
            else if (format == "cm")
            {
                // dokladnosc 1 miejsca po przecinku
            }
            else if (format == "mm")
            {
                // bez miejsc po przecinku
            }
            else
                throw new FormatException();


            throw new NotImplementedException();
        }


    }
}
