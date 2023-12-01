using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRogue.Rendering
{
    public class Screen
    {
        int rows { get; set; }
        int columns { get; set; }

        int offsetx { get; set; }
        int offsety { get; set; }

        public string title { get; private set; } = "New screen";
        public string subtitle { get; private set; } = "1-1";

        private char borderchar = '#';
        private int borderamount = 0;

        public List<Layer> layers = new List<Layer>();
        public char[,] RenderScreen()
        {
            char[,] screenResult = new char[rows+(2*borderamount),columns+(2*borderamount)];
            for(int i = borderamount; i > 0; i--) //Border Rendering
            {
                for(int j = 0; j < columns + (borderamount * 2); j++) // top and bottom margins
                {
                    screenResult[borderamount - i, j] = borderchar;
                    screenResult[rows - i, j] = borderchar;
                }
                for(int w = 0; w < rows + borderamount * 2; w++) // left and right margins
                {
                    screenResult[w, borderamount - i] = borderchar;
                    screenResult[w, columns - i] = borderchar;
                }

            }
            foreach(var l in layers) //Layer-by-layer rendering
            {
                var render = l.RenderLayer();
                for (int i = borderamount; i < rows + borderamount; i++)
                {
                    for(int j = borderamount; j < columns + borderamount; j++)
                    {
                        screenResult[i, j] = render[i - borderamount, j - borderamount];
                    }
                }
            }
            return screenResult;
        }
    }
}
