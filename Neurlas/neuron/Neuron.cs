using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Neurlas.neuron
{
    class Neuron
    {
        public float X { get; }
        public float Y { get; }
        public float Width { get; }
        public float Height { get; }
        public Color BackColor = Color.FromArgb(3, 83, 164);

        public RectangleF recNeuron { get; private set; }

        public Neuron(int x, int y)
        {
            X = x;
            Y = y;
            Width = 10.0f;
            Height = 10.0f;

            recNeuron = new RectangleF(X, Y, Width, Height);
        }

        public Neuron(PointF location)
        {
            X = location.X;
            Y = location.Y;
            Width = 10.0f;
            Height = 10.0f;

            recNeuron = new RectangleF(X, Y, Width, Height);
        }
    }
}
