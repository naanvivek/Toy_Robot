﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy_Robot.Toy;

namespace Toy_Robot.Console_Checker.Interface
{
    public interface IInputParser
    {
        // Interface to process the raw input from the user.
        Command ParseCommand(string[] rawInput);

        // This extracts the parameters from the user's input.        
        PlaceCommandParameter ParseCommandParameter(string[] input);
    }
}
