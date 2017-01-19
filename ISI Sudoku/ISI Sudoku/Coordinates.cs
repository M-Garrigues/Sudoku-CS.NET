using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISI_Sudoku
{
    class Coordinates
    {
        private int x;
        private int y; 

        public int getX()
        {
            return x; 
        }

        public int getY()
        {
            return y; 
        }

        public void setX(int newX)
        {
            x = newX; 
        } 

        public void setY(int newY)
        {
            y = newY; 
        }

        public Coordinates()
        {
            x = 0;
            y = 0; 
        }

        public Coordinates(int newX, int newY)
        {
            x = newX;
            y = newY; 
        }
        public Coordinates nextCoordinates()
        {

            if (y==8)
            {
                y = 0;

                x++; 
            } else
            {
                y++; 
            }
            return new Coordinates(x, y); 
        }

    }
}
