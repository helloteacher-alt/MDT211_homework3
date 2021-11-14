using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    class Node
    {
        public Node next;
        public string instruction;
        public string data;
        public Node (string instructionValue, string dataValue)
        {
            instruction = instructionValue;
            data = dataValue;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", instruction, data);
        }
    }
}
