using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasHandleBars { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle drives on 2 wheels");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Virtual Method");    
        }
    }
}
