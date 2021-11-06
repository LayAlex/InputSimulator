using System;
using System.IO;
using WindowsInput;

namespace InputSimulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputSimulator Simulator = new InputSimulator();

            var str = "hello"; // File.ReadAllText(@"file path");

            Simulator.Keyboard.Sleep(500).TextEntry(str);

            Console.ReadKey();
        }
    }
}
