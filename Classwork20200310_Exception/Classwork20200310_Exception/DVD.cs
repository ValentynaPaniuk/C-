using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get; }

        public void Insert()
        {
            this.hasDisk = true;
        }

        public void Reject()
        {
            this.hasDisk = false;
        }

        public string GetName()
        {
            return "DVD";
        }
    }
}
