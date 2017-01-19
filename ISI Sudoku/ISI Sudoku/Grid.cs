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
                if (tabGrid[x, j] == i) test = false;
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

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (tabGrid[xdep + j, ydep + k] == i) test = false;
                }
            }
            return test;
        }



        public bool checkAll(int x, int y, int i)
        {
            return (checkColumn(x, i) && checkLine(y, i) && checkSquare(x, y, i));
        }


        public bool fill()
        {
            Coordinates coordinates = new Coordinates();
            int count = 0;
            return fill2(count, coordinates);
        }

        private Boolean fill2(int count, Coordinates coordinates)
        {
            if (count == 81)
            {
                return true;
            }
            else
            {
                List<int> listValues = newListValues();
                int sizeList = 9;
                int index, valueTested;
                while (sizeList > 0)
                {
                    Console.WriteLine("Counteur : " + count); 
                    Console.WriteLine("Size : " + sizeList); 
                    Random rand = new Random();
                    index = rand.Next(0, sizeList);
                    Console.WriteLine("index : "+index); 
                    valueTested = listValues[index];
                    //listValues.ForEach(Console.WriteLine);
                    Console.WriteLine(coordinates.getX() + "   " + coordinates.getY());

                    Console.WriteLine("valeur testée : " + valueTested);

                    if (checkAll(coordinates.getX(), coordinates.getY(), valueTested))
                    {

                        tabGrid[coordinates.getX(), coordinates.getY()] = valueTested;
                        Console.WriteLine("Valeur validée : " + valueTested);
                        if (fill2(count + 1, coordinates.nextCoordinates()))
                        {
                            return true;
                        }
                        coordinates.previousCoordinate();
                    }
                    
                    
                        Console.WriteLine("Remove value " + listValues[index] + " at index " + index); 
                        listValues.RemoveAt(index);
                        sizeList = listValues.Count();
                    
                }
                tabGrid[coordinates.getX(), coordinates.getY()] = 0;
                return false;
            }
            
        }

        public List<int> newListValues()
        {
            List<int> values = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                values.Add(i);
            }
            return values;

        }

        public void Display()
        {
            for (int i =0; i<9; i++)
            {
                for (int j=0; j<9; j++)
                {
                    Console.WriteLine(tabGrid[i, j]); 
                }
                Console.WriteLine('\n');


            }
        }


    }
}
