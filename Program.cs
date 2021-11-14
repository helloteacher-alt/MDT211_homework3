using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue CPUq = new Queue();
            string instruction = "", data;
            int count = 0;
            while (instruction != "?")
            {
                instruction = Console.ReadLine();
                if (instruction=="?")
                {
                    break;
                }
                data = Console.ReadLine();
                Node CPU = new Node(instruction, data);
                CPUq.Push(CPU);
            }

            Node instructionQ;
            while (true)
            {
                instructionQ = CPUq.Pop();
                count++;
                if (instructionQ == null)
                {
                    break;
                }
            }
            Console.WriteLine("CPU cycles needed:{0}",count);
        }
    }
}
