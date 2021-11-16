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
        DrawingNeurons draw;
        MovementOfNeurons movementOfNeurons;
        CreateNeuronsLines neuronLines;
        DrawingNeuronsLines drawNeuronLines;

        List<Neuron> neuronsCollection;

        float oldMouseLocationX = 0;
        float oldMouseLocationY = 0;
        float newMouseLocationX;
        float newMouseLocationY;

        public MainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(0, 18, 51);

            draw = new DrawingNeurons();
            movementOfNeurons = new MovementOfNeurons();
            neuronLines = new CreateNeuronsLines();
            drawNeuronLines = new DrawingNeuronsLines();
            //neuronsCollection = new List<Neuron>();
        }



        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(this.BackColor);

            PointF centerPoint = new PointF(newMouseLocationX, newMouseLocationY);

            foreach (var point in neuronLines.linesPoint)
                drawNeuronLines.Draw(g, point.Point, centerPoint);

            draw.DrawCollection(g, neuronsCollection);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

            CreateNeurals createNeurlas = new CreateNeurals();
            neuronsCollection = createNeurlas.CreateCollection(400, Width * 2, Height * 2);
            Console.WriteLine(";");

            Invalidate();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            newMouseLocationX = e.X;
            newMouseLocationY = e.Y;

            //var point = movementOfNeurons.DirectionSide(oldMouseLocationX, oldMouseLocationY, newMouseLocationX, newMouseLocationY);
            //movementOfNeurons.Moving(ref neuronsCollection, point.X, point.Y);

            oldMouseLocationX = newMouseLocationX;
            oldMouseLocationY = newMouseLocationY;

            neuronLines.Create(newMouseLocationX, newMouseLocationY, neuronsCollection);

            Invalidate();
        }
    }
}
