using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISI_Sudoku
{
    public partial class MainForm : Form
    {
        private Grid grid;
        int niveau;

        public MainForm()
        {
            grid = new Grid();

            InitializeComponent();

            SGV.RowCount = 9;
            SGV.ColumnCount = 9;
            SGV.AllowUserToResizeColumns = false;
            SGV.AllowUserToResizeRows = false;
            for (int i = 0; i < 9; i++)
            {
                SGV.Columns[i].Width = 50;
                for (int j = 0; j < 9; j++)
                {
                    SGV.Rows[j].Height = 50;
                    SGV.Rows[j].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(grid.TabGrid[0,0] != 0)
            grid.setZeros(81); // A MODIFIER

            grid.fill();

            grid.setZeros(niveau);

            grid.Display();


            

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    SGV.Rows[i].Cells[j].Selected = false;
                    SGV.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    SGV.Rows[i].Cells[j].ReadOnly = true;
                    SGV.Rows[i].Cells[j].Value = grid.TabGrid[i,j];
                    if ((int)SGV.Rows[i].Cells[j].Value == 0)
                    {
                        SGV.Rows[i].Cells[j].Value = null;
                        SGV.Rows[i].Cells[j].Style.BackColor = Color.White;
                        SGV.Rows[i].Cells[j].ReadOnly = false;

                    }
                }
            }
           
        }






        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            niveau = 15 + (int)((int)choixNiveau.Value * 4.5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!grid.checkGrid().Any()) Console.WriteLine("BRAVOOOOOOLkjqsbckqsbckqcuiq");
            else Console.WriteLine("nope");
        }
    }
}
