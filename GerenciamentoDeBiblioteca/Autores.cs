using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeBiblioteca
{
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Digite o nome do autor");
            string autor = Console.ReadLine();


        }
    }
}
