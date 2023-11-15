using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy_Robot.Toy;

namespace Toy_Robot.Board.Interface
{
    public interface IToyBoard
    {
        // this interface enables access to a boolean method that returns
        // true or false if the position of the robot is within the board
        bool IsValidPosition(Position position);
    }
}
