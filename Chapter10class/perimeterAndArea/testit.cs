using System;


namespace Chapter10class
{
    class testit
    {
        static void Main(string[] args)
        {
            try
            {
                //use the 2 parameter constructor
                Rectangle rec = new Rectangle(12.6686534, 35.65464662);
                Console.WriteLine(rec);
                
                
                /*
                //use the no-parameter constructor
                Rectangle rec2 = new Rectangle(12.541543, 13.51484855);
                rec2.Length = 5;
                Console.WriteLine(rec2);

                Console.WriteLine();

                //object initializer
                Rectangle rec3 = new Rectangle { Length = 13, Width = 5 };
                Console.WriteLine(rec3);

                Console.WriteLine();
                */


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("You messsed up " + ex.Message);

            }
           

            Console.ReadKey();


        }
    }
}
