using System;

namespace KeyboardTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard(9, 5);

            string renderedKeypad = keyboard.Draw();

            Console.WriteLine(renderedKeypad);
        }
    }
}
