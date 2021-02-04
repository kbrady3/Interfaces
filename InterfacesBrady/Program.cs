//Big O: O(1)
/**************************************************************
* Name        : InterfacesBrady
* Author      : Kabrina Brady
* Created     : 1/27/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using InterfacesBrady.Models;
using System;

namespace InterfacesBrady
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 5);
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimeter());

            Square s = new Square(5);
            Console.WriteLine(s.Area());
            Console.WriteLine(s.Perimeter());
        }
    }
}
