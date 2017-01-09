using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISI_Sudoku
{
    public class Grid
    {
        private int[,] tabGrid;


        public Grid()
        {
            this.tabGrid = new int[9, 9];
        }

        public int[,] TabGrid
        {
            get
            {
                return tabGrid;
            }
            set
            {
                tabGrid = value;
            }
        }



        public bool checkColumn(int x, int i)
        {
            bool test = true;
            for (int j = 0; j < 9; j++)
            {
                if (tabGrid[x,j] == i) test = false;
            }

            return test;
        }


        public bool checkLine(int y, int i)
        {
            bool test = true;
            for (int j = 0; j < 9; j++)
            {
                if (tabGrid[j, y] == i) test = false;
            }

            return test;
        }


        public bool checkSquare(int x, int y, int i)
        {
            bool test = true;

            int xdep = x - x % 3;
            int ydep = y - y % 3;

            for(int j = 0; j < 3; j++)
            {
                for (int k = 0 ; k < 3; k++)
                {
                    if (tabGrid[xdep + j, ydep + k] == i) test = false;
                }
            }
            return test;
        }


        public void fill()
        {
            int count = 0;

        }

        private bool fill2(int x, int y, int count)
        {
            if (count == 81) return true;

            List<int> valeurs = new List<int>();
            for(int i =1; i < 10; i++)
            {
                valeurs.Add(i);
            } 




        } 
    }   


}
