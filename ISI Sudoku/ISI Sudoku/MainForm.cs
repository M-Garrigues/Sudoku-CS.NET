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
        int level = 42;
        Boolean newG = true;
        private System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
        private Timer mytimer = new Timer();

        public MainForm()
        {
            grid = new Grid();

            InitializeComponent();

            SGV.RowCount = 9;
            SGV.ColumnCount = 9;
            SGV.AllowUserToResizeColumns = false;
            SGV.AllowUserToResizeRows = false;

            SGV.Columns[2].DividerWidth = 3;
            SGV.Columns[5].DividerWidth = 3;
            SGV.Rows[2].DividerHeight = 3;
            SGV.Rows[5].DividerHeight = 3;

            SGV.ClearSelection();

            for (int i = 0; i < 9; i++)
            {
                SGV.Columns[i].Width = 65;
                for (int j = 0; j < 9; j++)
                {
                    SGV.Rows[j].Height = 65;
                    SGV.Rows[j].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    SGV.Rows[j].Cells[i].Selected = false;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mytimer.Enabled = true;
            stopWatch.Reset();
            stopWatch.Start();
            



            if (!newG)
                grid.resetAll();

            grid.fill();

            newG = false;

            grid.setZeros(level);

            

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
                        SGV.Rows[i].Cells[j].ReadOnly = false;
                        SGV.Rows[i].Cells[j].Style.BackColor = Color.White;
                        SGV.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
           
        }

 




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            level = 40 + (int)((int)choixNiveau.Value * 2.5);

            if (level == 40) level = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!newG)
            {


            stopWatch.Stop();
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(SGV.Rows[j].Cells[i].Value != null) 
                    grid.TabGrid[i,j] = int.Parse(SGV.Rows[j].Cells[i].Value.ToString());
                }
            }


            if (!grid.checkGrid().Any())
            {
                MessageBox.Show("Félicitations, vous avez gagné!\n                   Temps écoulé:\n                          "+
                stopWatch.Elapsed.Hours.ToString("00") + ":" +
              stopWatch.Elapsed.Minutes.ToString("00") + ":" +
             stopWatch.Elapsed.Seconds.ToString("00") );

                    
            }
            else MessageBox.Show("Il y a des erreurs, essayez encore!");


            }
        }
    }
}
