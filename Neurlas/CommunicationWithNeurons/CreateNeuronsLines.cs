using Neurlas.neuron;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurlas.CommunicationWithNeurons
{
    class CreateNeuronsLines
    {
        public List<Neuron> linesPoint { get; private set; }
        float radius = 150;


        public CreateNeuronsLines()
        {
            linesPoint = new List<Neuron>();
        }

        public void Create(float x, float y, List<Neuron> neurons)
        {
            foreach(var neuron in neurons)
            {
                if((neuron.X - x)* (neuron.X - x) + (neuron.Y - y)* (neuron.Y - y) < radius * radius)
                {
                    linesPoint.Add(neuron);
                }
                else
                {
                    if (linesPoint.Contains(neuron)) linesPoint.Remove(neuron);
                }
            }
        }
    }
}
