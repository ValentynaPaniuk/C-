using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    abstract class Disk:IDisk
    {
        string memory;
        int memSize;
        string Memory { get; set; }
        string MemSize { get; set; }

        public Disk() { }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
        }

        public string Read()
        {
            return this.memory;
        }

        public void Write(string text)
        {
            Console.WriteLine($"Disk {text}");
        }
    }
}
