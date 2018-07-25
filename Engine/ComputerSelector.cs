﻿using CommonContracts;
using WindowsComputer;

namespace Engine
{
    internal static class ComputerSelector
    {
        public static IComputer GetCurrentComputer()
        {
            // a way to determine which OS is in current computer
            // for now, we return Windows Computer only for simplicity
            return new WindowsOS();
        }
    }
}
