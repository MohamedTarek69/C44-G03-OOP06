using Session_06.Project_01;

namespace Session_06
{
    internal class Program
    {
        public static void InputPoint(Point3D point)
        {
            bool IsParseX;
            int x;
            do
            {
                Console.Write("Enter X Coordinate: ");
                IsParseX = int.TryParse(Console.ReadLine(), out x);
                if (IsParseX)
                {
                    point.X = x;
                }
                else
                {
                    Console.WriteLine("Invalid input for X Coordinate. Please try again.");
                }
            } while (!IsParseX || x<=0);

            bool IsParseY;
            int y;
            do
            {
                Console.Write("Enter Y Coordinate: ");
                IsParseY = int.TryParse(Console.ReadLine(), out y);
                if (IsParseY)
                {
                    point.Y = y;
                }
                else
                {
                    Console.WriteLine("Invalid input for Y Coordinate. Please try again.");
                }
            } while (!IsParseY || y <= 0);

            bool IsParseZ;
            int z;
            do
            {
                Console.Write("Enter Z Coordinate: ");
                IsParseZ = int.TryParse(Console.ReadLine(), out z);
                if (IsParseZ)
                {
                    point.Z = z;
                }
                else
                {
                    Console.WriteLine("Invalid input for Z Coordinate. Please try again.");
                }
            } while (!IsParseZ || z <= 0);

            Console.Clear();

        }
        static void Main(string[] args)
        {
            #region Project 01
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString()); //Point Coordinates: (10, 10, 10)

            //Point3D P01 = new Point3D();
            //Point3D P02 = new Point3D();
            //Console.WriteLine("Please Enter The First Point: ");
            //InputPoint(P01);
            //Console.WriteLine("Please Enter The Second Point: ");
            //InputPoint(P02);

            //Console.WriteLine($"Frst Point: \n {P01}");
            //Console.WriteLine($"Second Point: \n {P02}");

            //Before overloding the == operator the == will work but will compare the references
            //if (P01 == P02)
            //{
            //    Console.WriteLine("The two points are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("The two points are not equal.");
            //}
            //After overloding the == operator the == will work but now it will compare the values
            //if (P01 != P02)
            //{
            //    Console.WriteLine("The two points are not equal.");
            //}
            //else
            //{
            //    Console.WriteLine("The two points are equal.");
            //}

            //Point3D[] points =
            //{
            //    new Point3D(5, 2, 9),
            //    new Point3D(5, 6, 8),
            //    new Point3D(3, 2, 4),
            //    new Point3D(1, 2, 3)
            //};
            //Array.Sort(points);
            //Console.WriteLine("Sorted Points:");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Point3D P01 = new Point3D(1, 2, 3);
            //Point3D P02 = new Point3D(4, 5, 6);

            //Console.WriteLine("P01: ");
            //Console.WriteLine($"P01 => {P01.GetHashCode()}");
            //Console.WriteLine(P01);
            //Console.WriteLine("P02: ");
            //Console.WriteLine($"P02 => {P02.GetHashCode()}");
            //Console.WriteLine(P02);

            //P01.X = 10;

            //P02 = (Point3D)P01.Clone();
            //Console.WriteLine("After Cloning P01 to P02:");
            //Console.WriteLine("P01: ");
            //Console.WriteLine($"P01 => {P01.GetHashCode()}");
            //Console.WriteLine(P01);
            //Console.WriteLine("P02: ");
            //Console.WriteLine($"P02 => {P02.GetHashCode()}");
            //Console.WriteLine(P02);

            #endregion
        }
    }
}
