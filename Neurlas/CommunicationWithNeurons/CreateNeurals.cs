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
        Random randPoint = new Random();
        Random randSize = new Random();

        public List<Neuron> NeurlasCollection;
        int limitation = 10;

        private PointF GetRandomPoint(int Width, int Height)
        {
            
            float x;
            float y;
            bool check = false;


            while (true)
            {
                x = randPoint.Next(0, Width);
                y = randPoint.Next(0, Height);

                foreach (var neuron in NeurlasCollection)
                {
                    if (x >= neuron.X - limitation && x <= neuron.X + neuron.Width + limitation) break;
                    if ((y <= neuron.Y - limitation || y >= neuron.Y - limitation) && (y >= neuron.Y + neuron.Height + limitation || y <= neuron.Y + neuron.Height + limitation)) { check = true; break; }
                }

                if (check)
                    break;
            }

            return new PointF(x, y);
        }

        private SizeF GetRandomSize()
        {
            float W;
            float H;

            W = randSize.Next(8, 12);
            H = W;

            return new SizeF(W, H);
        }

        public List<Neuron> CreateCollection(int Count, int formWidth, int formHeight)
        {
            NeurlasCollection = new List<Neuron>();
            NeurlasCollection.Add(new Neuron(100, 100, 10, 10));

            for(int i = 0;i < Count; i++)
            {
                var size = GetRandomSize();
                var point = GetRandomPoint(formWidth, formHeight);
                Neuron neuron = new Neuron(point, size);
                NeurlasCollection.Add(neuron);
            }

            return NeurlasCollection;
        }
    }
}
