using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRogue.Game
{
    public class GameState
    {
        public Terrain[,] Terrain;
        public Entity[,] Entities;
    }

    public class Terrain
    {
        public enum TerrainType
        {
            Solid, //entities cannot step into this coordinate
            NonSolid //entities can step into this coordinate
        }

        public TerrainType type;
        public char renderedChar;

        public Terrain(TerrainType type, char renderedChar)
        {
            this.type = type;
            this.renderedChar = renderedChar;
        }

        public Terrain DefaultWall = new Terrain()
        {
            type = TerrainType.Solid,
        } 
    }

    public class Entity
    {
        public enum EntityType
        {
            Player,
            Creature,
            Interactible
        }

        public EntityType type;

    }
}
