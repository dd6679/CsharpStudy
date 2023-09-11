using System;

namespace Ex13_1
{
    delegate int MyDelegate(int a, int b);

    class MainApp
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;
            Callback = (a, b) => a + b;
            Console.WriteLine(Callback(3, 4));
            Callback = (a, b) => a - b;
            Console.WriteLine(Callback(7, 5));
        }
    }
}
