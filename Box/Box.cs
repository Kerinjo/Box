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

        public Box( double width = 10, double length = 10, double height = 10,
                    UnitOfMeasure measure = UnitOfMeasure.Meter)
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
            string returnString = $"{Math.Round(width, 3)} {measure} \u00D7 " +
                                  $"{Math.Round(length, 3)} {measure} \u00D7 " +
                                  $"{Math.Round(height, 3)} {measure}";
            return returnString;
        }

        public string ToString(string format)
        {
            // TODO: implement using IFormattable interface
            if (format == "m")
            {
                // precision 3 
                switch (measure)
                {
                    case UnitOfMeasure.Meter:
                    {
                        return $"{width}m \u00D7 {length}m \u00D7 {height}m";
                    }
                    case UnitOfMeasure.Centimeter:
                    {
                        return $"{width * 0.1}m \u00D7 {length * 0.1}m \u00D7 {height * 0.1}m";
                    }
                    case UnitOfMeasure.Milimeter:
                    {
                         return $"{width * 0.01}m \u00D7 {length * 0.01}m \u00D7 {height * 0.01}m";
                    }
                }
            }
            else if (format == "cm")
            {
                // precision 1
                switch (measure)
                {
                    case UnitOfMeasure.Meter:
                        {
                            return $"{Math.Round(width * 10, 1)}cm \u00D7 " +
                                   $"{Math.Round(length * 10, 1)}cm \u00D7 " +
                                   $"{Math.Round(height * 10, 1)}cm";
                        }
                    case UnitOfMeasure.Centimeter:
                        {
                            return $"{Math.Round(width, 1)}cm \u00D7 " +
                                   $"{Math.Round(length, 1)}cm \u00D7 " +
                                   $"{Math.Round(height, 1)}cm";
                        }
                    case UnitOfMeasure.Milimeter:
                        {
                            return $"{Math.Round(width * 0.1, 1)}cm \u00D7 " +
                                   $"{Math.Round(length * 0.1, 1)}cm \u00D7 " +
                                   $"{Math.Round(height * 0.1, 1)}cm";
                        }
                }
            }
            else if (format == "mm")
            {
                switch (measure)
                {
                    case UnitOfMeasure.Meter:
                        {
                            return $"{Math.Round(width * 100, 0)}mm \u00D7 " +
                                   $"{Math.Round(length * 100, 0)}mm \u00D7 " +
                                   $"{Math.Round(height * 100, 1)}mm";
                        }
                    case UnitOfMeasure.Centimeter:
                        {
                            return $"{Math.Round(width * 10, 0)}mm \u00D7 " +
                                   $"{Math.Round(length * 10, 0)}mm \u00D7 " +
                                   $"{Math.Round(height * 10, 0)}mm";
                        }
                    case UnitOfMeasure.Milimeter:
                        {
                            return $"{Math.Round(width, 0)}mm \u00D7 " +
                                   $"{Math.Round(length, 0)}mm \u00D7 " +
                                   $"{Math.Round(height, 0)}mm";
                        }
                }
            }
            else
                throw new FormatException();
            throw new Exception();
        }
    }
}
