namespace Session_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            #endregion
        }
    }
}
