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

        public PointF Point { get; }
        public SizeF Size { get; }

        public Color BackColor = Color.FromArgb(4, 102, 200);

        public RectangleF recNeuron { get; private set; }

        public Neuron(int x, int y, int W, int H)
        {
            X = x;
            Y = y;
            Width = W;
            Height = H;

            Point = new PointF(X, Y);
            Size = new SizeF(Width, Height);

            recNeuron = new RectangleF(X, Y, Width, Height);
        }

        public Neuron(PointF location, SizeF size)
        {
            X = location.X;
            Y = location.Y;
            Width = size.Width;
            Height = size.Height;

            Point = new PointF(X, Y);
            Size = new SizeF(Width, Height);

            recNeuron = new RectangleF(X, Y, Width, Height);
        }
    }
}
