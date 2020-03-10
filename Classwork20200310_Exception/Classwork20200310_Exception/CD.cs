using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    internal class CD : Disk , IRemoveableDisk
    {
        
        bool hasDisk;

        public bool HasDisk { get; }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }
        public string GetName()
        {
            return "CD";
        }
    }
}
