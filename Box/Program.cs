namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var box1 = new Box(4, 54, 102, UnitOfMeasure.Milimeter);
            var box2 = new Box(10, 10, 10, UnitOfMeasure.Centimeter);
            var box3 = new Box(10, 9.4001, 10, UnitOfMeasure.Meter);


            Console.WriteLine(box1.ToString("m"));
            Console.WriteLine(box2.ToString("m"));
            Console.WriteLine(box3.ToString("m"));

            Console.WriteLine(box1.ToString("cm"));
            Console.WriteLine(box2.ToString("cm"));
            Console.WriteLine(box3.ToString("cm"));

            Console.WriteLine(box1.ToString("mm"));
            Console.WriteLine(box2.ToString("mm"));
            Console.WriteLine(box3.ToString("mm"));
        }
    }
}
