using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Pacman.BL
{

    //Game Cell Class...................................................

    class GameCell
    {
        // Attributes....................................
        public int x;
        public int y;
        GameObject currentGameObject;
        GameGrid gameGrid;

        // Functions........................
        GameCell(int aX, int aY, GameGrid aGrid)
        {
            x = aX;
            y = aY;
            gameGrid = aGrid;
        }
        public GameObjectType nextCell(GameDirection direction)
        {

        }

    }
        //Game Grid Class.................................................


        class GameGrid
        {
            // Attributes..............................
            public int rows;
            public int coulmns;
            GameCell[,] GameCells = new GameCell[20, 23];

            //Functions........................

            public GameGrid(string aFileName, int aRow, int aCols)
            {
                rows = aRow;
                coulmns = aCols;
                GameCell cells = new GameCell(rows,aCols);
            

            }

            public void loadGrid(string aFileName)
            {

            }

            public GameCell GetCell(int aX, int aY)
            {
             
            }

        }

        // Game Object Class........................................................

        class GameObject
        {

            public char displayCharacter;
            public GameCell CurrentCell;
        public Enum GameObjectType;


        public GameObject(GameObjectType type,char DisplayCharacter)
        {
            GameObjectType = type;
            displayCharacter = DisplayCharacter;
        }

        public static GameObjectType GetGameObjectType(string displayCharacter)
        {
            
        }

        
    }

    // Game Object Type.................................................


    enum GameObjectType
    {
        WALL,
        PLAYER,
        ENEMY,
        REWARD,
        NONE
    }

    
    //Game Direction Enum.....................................................

    enum GameDirection
    {
        LEFT,
        Right,
        Up,
        Down
    }

}
