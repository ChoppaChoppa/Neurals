using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neurlas.CommunicationWithNeurons;
using Neurlas.neuron;

namespace Neurlas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(0, 18, 51);
        }



        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateNeurals createNeurlas = new CreateNeurals();
            var neurons = createNeurlas.CreateCollection(100, Width, Height);
            Console.WriteLine(";");
        }
    }
}
