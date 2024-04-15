namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var box1 = new Box(10, 10, 10, UnitOfMeasure.Centimeter);
            var box2 = new Box(10, 9, 10, UnitOfMeasure.Meter);
            var box3 = new Box(4, 10, 10.1239043, UnitOfMeasure.Centimeter);


            Console.WriteLine(box3);
        }
    }
}
