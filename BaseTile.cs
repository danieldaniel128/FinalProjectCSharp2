using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    public abstract class BaseTile
    {

        public abstract Vector2 Position { get; protected set; }
        public abstract TileObject _gameObject { get; protected set; }

        public virtual string TileContainer { get; set; }
        public ConsoleColor TileColor { get; set; }


        public BaseTile()
        {
            TileContainer = "[ ]";
            _gameObject = null;
        }

        public BaseTile(char tileObject, ConsoleColor tileColor = ConsoleColor.White)
        {
            TileColor = tileColor;
            TileContainer = "[ ]";
            TileContainer = TileContainer.Replace(' ', tileObject);
            _gameObject = null;
        }
        public BaseTile(int x, int y, TileObject gameObject)
        {
            _gameObject = gameObject;
        }


    
}
