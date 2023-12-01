using OpenRogue.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRogue.Rendering
{
    public abstract class Layer
    {
        public bool overrideLower = false;
        public bool overlay = false;

        public char[,] visibleGrid;

        public Layer(int rows, int columns)
        {
            visibleGrid = new char[rows, columns];
        }

        public virtual char[,] RenderLayer()
        {
            return visibleGrid;
        }
    }

    public class EnvironmentLayer : Layer
    {
        public Terrain[,] environment;

        public EnvironmentLayer(int rows, int columns)
        {
            
        }

        private Terrain[,] generateEmpty(int rows, int columns)
        {
            environment = new Terrain[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(i == 0 || i == rows)
                    {
                        environment[i,j] = Terrain.
                    }
                }
            }
        }
        
    }

    public class EntityLayer : Layer
    {

    }

    public class TextLayer : Layer
    {

    }

    public class GasLayer : Layer
    {

    }

    public class ParticleLayer : Layer
    {

    }

    public class ObfuscationLayer
    {

    }
}
