using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork20200310_Exception
{
    class Comp
    {
        int countDisk;
        int countPrintDevice;
        List<Disk> list = new List<Disk>();
        List<IPrintInformation> printDevice = new List<IPrintInformation>();

        public Comp(int d, int pd)
        {
            this.countDisk = d;
            this.countPrintDevice = pd;
            //this.list = new List();

            
        }

        public void AddDevice(int index, IPrintInformation si)
        {
            if (index == 1)
            {
                si = new Monitor();
            }
            else if (index == 2)
            {
                si = new Printer();
            }
        }
        public void AddDisk(int index, Disk d)
        {
            index--;
            list.Add(d);
        }
        //public bool CheckDisk(string device)
        //{
            
        //}
        //public void InsertReject(string device, bool b)
        //{

        //}
        //public bool PrintInfo(string text, string device)
        //{

        //}
        // public string ReadInfo(string device)
        //{

        //}
        public void ShowDisk()
        {
            foreach (var e in list)
            {
                Console.WriteLine(e.Read());
            }
        }
        public void ShowPrintDevice()
        {
            foreach (var e in printDevice)
            {
                e.Print(e.GetName());
            }
        }
        //bool WriteInfo(string text, string showDevice)
        //{

        //}


    }
}
