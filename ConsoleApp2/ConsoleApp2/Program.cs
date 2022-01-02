using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 1;
            Console.WriteLine("Odd\tEven");
            Console.WriteLine("--------------");
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(odd + "\t" + (odd+2));
            }
        }

    }
}

/*namespace ConsoleApp1
{
    public class MyClass
    {
        public void Dispaly()
        {
            Console.WriteLine("Display from ConsoleApp2");
        }
    }
}
*/
