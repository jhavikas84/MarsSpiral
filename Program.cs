using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VicRoads.MarsRover.Core;

namespace VicRoads.MarsRover
{
    class Program
    {
        const string _Rover1Instruction = @"LMLMLMLMM";
        const string _Rover2Instruction = @"MMRMMRMRRM";

        static void Main(string[] args)
        {
            VicRoadsMars();
            Console.ReadLine();
        }

        private static void VicRoadsMars()
        {
            Plateau plateau = new Plateau(5, 5);
            var rover1 = new Core.MarsRover(1, 2, Core.MarsRover.Direction.North, plateau);
            var rover2 = new Core.MarsRover(3,3, Core.MarsRover.Direction.East, plateau);
            rover1.ProcessRoverInstruction(_Rover1Instruction);
            rover2.ProcessRoverInstruction(_Rover2Instruction);

            Console.WriteLine(rover1.ToString());
            Console.WriteLine(rover2.ToString());            
        }
    }
}
