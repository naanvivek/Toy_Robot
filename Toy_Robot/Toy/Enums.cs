using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Robot.Toy
{
    internal class Enums
    {
    }
    // This enumerates the program commands for use
    // by the toy class rotate method.
    public enum Direction
    {
        North,
        East,
        South,
        West
    }
    // This enumerates the program commands for use
    // by the console checker classes.
    public enum Command
    {
        Place,
        Move,
        Left,
        Right,
        Report
    }
}
