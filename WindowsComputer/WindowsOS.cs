﻿using System.Windows.Forms;
using Abstractions;

namespace WindowsComputer
{
    public class WindowsOS : IComputer
    {
        public WindowsOS()
        {
            Screen = new WindowsScreen();
            Mouse = new WindowsMouse();
            Keyboard = new WindowsKeyboard(Mouse);
        }

        public IScreen Screen { get; }

        public IKeyboard Keyboard { get; }

        public IMouse Mouse { get; }

        public void DisplayMessageBox(string message)
        {
            // TODO: should make it top most
            MessageBox.Show(message, "Test Result", MessageBoxButtons.OK);
        }
    }
}
