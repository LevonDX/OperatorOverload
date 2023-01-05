namespace OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 5);
            Point p2 = new Point(7, 8);

            Point p3 = p1 + p2;

            p3 = p1 + 6;

            p1 = p3++;

            if (p1 || p3)
            {

            }

            double d = 6.6;

            string s = (string)p1;
        }
    }
}