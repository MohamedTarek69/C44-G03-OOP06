using Session_06.Project_01;
using Session_06.Project_03;
using System.Globalization;

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
            #region Culture
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            #endregion

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

            #region Project 02
            //Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            //Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            //Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            //Console.WriteLine($"Divide: {Maths.Divide(10, 5)}");

            #endregion

            #region Project 03
            //Console.WriteLine("Please choose your type: \n1. Regular\n2. Premium\n3. Guest");
            //int choice = 0;
            //do
            //{
            //    Console.Write("Your Option: ");
            //    bool IsValidChoice = int.TryParse(Console.ReadLine(), out choice);
            //    if (IsValidChoice && choice >= 1 && choice <= 3)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            //    }
            //} while (true);

            //decimal Price = 0;
            //do
            //{
            //    Console.Write("Please Enter Product Price:");   
            //    bool IsValidChoice = decimal.TryParse(Console.ReadLine(), out Price);
            //    if (IsValidChoice)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            //    }
            //} while (true);

            //int Quantity = 0;
            //do
            //{
            //    Console.Write("Please Enter Product Quantity:");
            //    bool IsValidChoice = int.TryParse(Console.ReadLine(), out Quantity);
            //    if (IsValidChoice && Quantity > 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid choice. Please enter a positive integer.");
            //    }
            //} while (true);

            //User user;
            //switch (choice)
            //{
            //    case 1:
            //        user = new RegularUser();
            //        Console.WriteLine("User Type => RegularUser");
            //        break;
            //    case 2:
            //        user = new PremiumUser();
            //        Console.WriteLine("User Type => PremiumUser");
            //        break;
            //    case 3:
            //        user = new GuestUser();
            //        Console.WriteLine("User Type => GuestUser");
            //        break;
            //    default:
            //        user = new GuestUser();
            //        Console.WriteLine("Invalid choice Defaulting to Guest User.");
            //        break;
            //}

            //Discount discount = user.GetDiscount();
            //decimal zerodiscount = 0;
            //if (choice == 3)
            //{
            //    discount.Name = $"No Discount Available => {zerodiscount:C}";
            //}
            //decimal discountAmount = discount.CalculateDiscount(Price, Quantity);
            //decimal finalPrice = Price * Quantity - discountAmount;
            //Console.WriteLine($"Discount Type: {discount.Name}");
            //Console.WriteLine($"Discount Amount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");

            #endregion

        }
    }
}
