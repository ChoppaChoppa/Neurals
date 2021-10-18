using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neurlas.neuron;

namespace Neurlas.CommunicationWithNeurons
{
    class CreateNeurals
    {
        public List<Neuron> NeurlasCollection;
        int limitation = 10;

        private PointF GetRandomPoint(int Width, int Height)
        {
            Random rand = new Random();
            float x;
            float y;
            bool check = false;

            while (true)
            {
                x = rand.Next(0, Width);
                y = rand.Next(0, Height);

                foreach(var neuron in NeurlasCollection)
                {
                    if (x >= neuron.X - limitation && x <= neuron.X + neuron.Width + limitation) break;
                    if ((y <= neuron.Y - limitation || y >= neuron.Y - limitation) && (y >= neuron.Y + neuron.Height + limitation || y <= neuron.Y + neuron.Height + limitation)) { check = true; break; }
                }

                if (check)
                    break;
            }

            return new PointF(x, y);
        }

        public List<Neuron> CreateCollection(int Count, int W, int H)
        {
            NeurlasCollection = new List<Neuron>();
            NeurlasCollection.Add(new Neuron(100, 100));

            for(int i = 0;i < Count; i++)
            {
                var point = GetRandomPoint(W, H);
                Neuron neuron = new Neuron(point);
                NeurlasCollection.Add(neuron);
            }

            return NeurlasCollection;
        }
    }
}
