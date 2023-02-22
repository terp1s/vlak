using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlak
{
    enum Directions {Up,Down,Right,Left};
    enum Type { Apple, Tree, Elephant, Crown}

    class Game
    {
        Map map;
        
    }
    class Map
    {
        char[,] map;

        Vlak vlak;
        List<Prekazka> Prekazky;
        Door Door;

        public void Update()
        {
            map[vlak.VlakCol, vlak.VlakRow] = '=';

            
        }
    }
    class Prekazka
    {
        //souhlasim s ovocem :)
        Type Type;
    }
    class Vagon
    {
        Directions dir;
        Type Type;

        public int VagonRow;
        public int VagonCol;

    }
    class Vlak
    {
        public List<Vagon> Vagony = new List<Vagon>();

        public int VlakRow;
        public int VlakCol;

        Directions Dir;

        public void Move()
        {
            switch (Dir)
            {
                case Directions.Down:
                    VlakRow += 1;
                    break;
                case Directions.Up:
                    VlakRow -= 1;
                    break;
                case Directions.Left:
                    VlakCol-= 1;
                    break;
                case Directions.Right:
                    VlakCol += 1;
                    break;

            }

            for (int i = 0; i < Vagony.Count; i++)
            {
                
            }
        }
    }
    class Door
    {
        bool Opened = false;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
