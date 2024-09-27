using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PACMAN.BL
{
    class GameCell
    {
        int x;
        int y;
        GameObject currentGameObject;
        GameGrid grid;
        public GameCell(int x,int y,GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.grid = grid;
        }

        public GameCell nextCell(GameDirection direction)
        {
            if(direction == GameDirection.Left)
            {
                if(this.y > 0)
                {
                    GameCell ncell = grid.getCell(x, y - 1);
                    if(ncell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            
            if(direction == GameDirection.Right)
            {
                if(this.y < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.x,this.y+1);
                    if(ncell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if(direction == GameDirection.Up)
            {
                if(this.x > 0)
                {
                    GameCell ncell = grid.getCell(this.x - 1, this.y);
                    if(ncell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }

            if(direction == GameDirection.Down)
            {
                if(this.x < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.x + 1, this.y);
                    if(ncell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this;
        }
        public int X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }
        public GameObject CurrentGameObject
        {
            get { return currentGameObject; }
            set
            {
                currentGameObject = value;
            }
        }

    }
    class GameGrid
    {
        GameCell[,] cells;
        int rows;
        int cols;
        public GameGrid(string fileName,int rows,int cols)
        {
            this.rows = rows;
            this.cols = cols;
            cells = new GameCell[rows, cols];
            this.loadGrid(fileName);
        }

        public GameCell getCell(int x,int y)
        {
            return cells[x,y];
        }

        public int Rows
        {
            get { return rows; }
            set
            {
                rows = value;
            }
        }
        public int Cols
        {
            get { return cols; }
            set
            {
                cols = value;
            }
        }

        void loadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for(int row = 0; row < this.rows;row++)
            {
                record = fp.ReadLine();
                for(int col = 0; col < this.cols;col ++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    char displayCharacter = record[col];
                    GameObjectType type = GameObject.getGameObjectType(displayCharacter);
                    GameObject gameObject = new GameObject(type, displayCharacter);
                    cell.CurrentGameObject = gameObject;
                    cells[row,col] = cell;
                }
            }

            fp.Close();
        }
    }
    class GameObject
    {
        char displayCharacter;
        GameObjectType gameObjectType;
        GameCell currentCell;
        public GameObject(GameObjectType type,char displayCharacter)
        {
            this.displayCharacter = displayCharacter;
            this.gameObjectType = type;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {
            if(displayCharacter == '|' || displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALL;
            }
            if(displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }
            return GameObjectType.NONE;
        }
        public char DisplayCharacter
        {
            get { return displayCharacter; }
            set
            {
                displayCharacter = value;
            }
        }

        public GameObjectType GameObjectType
        {
            get { return gameObjectType; }
            set
            {
                gameObjectType = value;
            }
        }

        public GameCell CurrentCell
        {
            get { return currentCell; }
            set
            {
                currentCell = value;
                currentCell.CurrentGameObject = this;
            }
        }

    }
    enum GameDirection
    {
        Left,
        Right,
        Up,
        Down,
    }

    enum GameObjectType
    {
        WALL,
        PLAYER,
        ENEMY,
        REWARD,
        NONE,
    }

    class GamePacmanPlayer : GameObject
    {
        public GamePacmanPlayer(char displayCharacter, GameCell startCell)
            :base (GameObjectType.PLAYER,displayCharacter)
        {
            this.CurrentCell = startCell;
        }

        public GameCell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
