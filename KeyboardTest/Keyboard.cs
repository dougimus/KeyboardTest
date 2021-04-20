using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardTest
{
    class Keyboard
    {
        private char SelectedKey = 'A';
        private int CurrentPage;
        private readonly char?[] Layout = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '[', ']', '^', '_', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '/', '=', '@', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'q', 'x', 'y', 'z' };
        private int MaxRows;
        private int MaxCols;
        private char?[,] grid;

        public Keyboard(int maxRows, int maxCols)
        {
            MaxRows = maxRows;
            MaxCols = maxCols;
            grid = new char?[maxRows,maxCols];

            int pos = 0;

            for (int rows = 0; rows < MaxRows; rows++)
            {
                for (int cols = 0; cols < MaxCols; cols++)
                {
                    grid[rows, cols] = Layout[pos];
                    pos++;
                }
            }
        }

        public string Draw()
        {
            string output = "";
            int offset = CurrentPage * MaxRows;

            for (int rows = 0; rows < MaxRows; rows++)
            {
                for (int cols = 0; cols < MaxCols; cols++)
                {
                    if(grid[rows+offset,cols] == null)
                    {
                        output += "   ";
                    }
                    else if (grid[rows+offset,cols] == SelectedKey)
                    {
                        output += "<" + grid[rows+offset, cols] + ">";
                    }
                    else
                    {
                        output += "[" + grid[rows+offset,cols] + "]";
                    }
                    if(cols != MaxCols-1)
                    {
                        output += " ";
                    }
                }
                output += "\n";
            }

            return output;
        }
    }
}
