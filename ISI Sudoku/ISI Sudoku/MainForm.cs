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
        public MainForm()
        {
            InitializeComponent();
            Grid grille = new Grid();
            grille.fill();
            grille.Display();
            Console.WriteLine('D');

            if (!grille.checkGrid().Any())
                Console.WriteLine("La grille est bonne.");
            else
                Console.WriteLine("La grille est fausse.");

            Console.WriteLine("\n\n");

            grille.setZeros(80);

            grille.Display();
            Console.WriteLine("\n\n");

            grille.solve();

            grille.Display();

            if (!grille.checkGrid().Any())
                Console.WriteLine("La grille est bonne.");
            else
                Console.WriteLine("La grille est fausse.");
        }
    }
}
