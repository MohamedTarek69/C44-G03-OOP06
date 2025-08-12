using Session_06.Build_In_Interfaces;
using System.Globalization;
using System.Text;

namespace Session_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Culture
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            #endregion

            #region Shallow Copy and Deep Copy

            //------------------------------ Vedio 01 --------------------------------
            #region Array of Value Type
            //int[] Arr01 = { 1, 2, 3};
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"Hash Code of Arr01 => {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hash Code of Arr02 => {Arr02.GetHashCode()}"); //18643596

            #region Shallow Copy
            //Arr02 = Arr01; // Shallow Copy
            //               // Copy Value of Arr01 To Arr02
            //               // Copy Addresses - Happened in Stack
            //               // [Arr01 - Arr02] => Have Same Value
            //               // [Arr01 - Arr02] => Refer Same Object
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of Arr02 = {Arr02.GetHashCode()}"); //54267293

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            //Arr01[0] = 100;

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //100

            #endregion

            #region Deep Copy
            //object obj = Arr02;
            //obj = 10;
            //obj = 10.2;
            //obj = true;

            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //                              // Happened in Heep
            //                              // Create New object with Different and new identity then return it
            //                              // the New Object will have the same object state [Data] of Caller
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of Arr02 = {Arr02.GetHashCode()}"); //33574638

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            //Arr01[0] = 100;

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            #endregion

            #endregion

            //------------------------------ Vedio 02 --------------------------------
            #region Array of Reference Type

            #region Array of Reference Type ImMutable [String]
            //string[] Names01 = { "Mohamed" , "Ahmed" };
            //string[] Names02 = new String[2];
            //Console.WriteLine($"Hash Code of Name01 => {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hash Code of Name02 => {Names02.GetHashCode()}"); //18643596

            #region Shallow Copy
            //Names02 = Names01; // Shallow Copy
            //                   // Copy Value names01 => names02
            //                   // [names01 - names02] => Have Same Value
            //                   // [names01 - names02] => Refer to same obj

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Of names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode Of names02 = {Names02.GetHashCode()}"); //54267293

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed

            //Names01[0] = "Tarek";

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Tarek
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Tarek

            #endregion

            #region Deep Copy
            //Names02 = (string[])Names01.Clone(); // Deep Copy
            //                   // Happened in Heep
            //                   // Create New object with Different and new identity then return it
            //                   // the New Object will have the same object state [Data] of Caller

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Of names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode Of names02 = {Names02.GetHashCode()}"); //33574638

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed

            //Names01[0] = "Tarek";

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Tarek
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed

            #endregion

            #endregion

            //------------------------------ Vedio 03 --------------------------------
            #region Array of Reference Type Mutable [StringBuilder]
            //StringBuilder[] names01 = new StringBuilder[1];
            //names01[0] = new StringBuilder();

            //// null => Omar
            ////StringBuilder stringBuilder = new StringBuilder();
            ////stringBuilder.Append("Omar");

            ////names01[0] = "Omar";

            //names01[0].Append("omar"); // NullReferenceException

            //string[] names02 = new string[1];

            //names02[0] = "Omar"; // Syntax Suger

            //string[] names03 = new string[1];
            //names03[0] = new string("omar");

            //StringBuilder[] Names01 = { new StringBuilder("Mohamed") };
            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"Hash Code of Name01 => {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hash Code of Name02 => {Names02.GetHashCode()}"); //18643596

            #region Shallow Copy
            //Names02 = Names01;

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Of names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode Of names02 = {Names02.GetHashCode()}"); //54267293

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed

            //Names01[0].Append(" Tarek");

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed Tarek
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed Tarek

            #endregion

            #region Deep Copy
            //Names02 = (StringBuilder[])Names01.Clone();

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode Of names01 = {Names01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode Of names02 = {Names02.GetHashCode()}"); //33574638

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed

            //Names01[0].Append(" Tarek");

            //Console.WriteLine("After Changing");

            //Console.WriteLine($"names01[0] = {Names01[0]}"); //Mohamed Tarek
            //Console.WriteLine($"names02[0] = {Names02[0]}"); //Mohamed Tarek

            #endregion

            #endregion

            #endregion

            //------------------------------ Vedio 05 --------------------------------
            #region Build-In Interfaces

            #region IClonable
            //Employee employee01 = new Employee() { Id = 10, Name = "Omar", Salary = 5000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Mona", Salary = 8000 };

            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}");
            //// Array => Built in Class implement interface [ICloneable] => Clone    

            //employee02 = (Employee)employee01.Clone();

            ////employee02 = new Employee()
            ////{
            ////    Id = employee01.Id,
            ////    Name = employee01.Name,
            ////    Salary = employee01.Salary,
            ////};
            ////employee02 = new Employee(employee01);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}"); 

            #endregion

            //------------------------------Vedio 06--------------------------------
            #region IComparable
            //int[] numbers = { 4, 5, 6, 9, 1, 2, 7, 5 };
            //Array.Sort(numbers);
            ////int => Built in Struct implement interface [IComparable] => CompareTo
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Employee[] employees =
            //{
            //    new Employee() { Id = 10, Name = "Mohamed", Salary = 6000 },
            //    new Employee() { Id = 20, Name = "Ahmed", Salary = 10000 },
            //    new Employee() { Id = 30, Name = "Sama", Salary = 4000 },
            //    new Employee() { Id = 40, Name = "May", Salary = 5000 },
            //};

            //Array.Sort(employees);
            //Array.Reverse(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            ////InvalidOperationException



            #endregion

            #endregion



            #endregion
        }
    }
}
