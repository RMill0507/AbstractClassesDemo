﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasATrunk { get; set; } 
        public override void DriveAbstract()
        {
            Console.WriteLine("The car drives on 4 wheels");
        }
        
    
    }

}
