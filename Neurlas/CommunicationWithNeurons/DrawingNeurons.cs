using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neurlas.neuron;

namespace Neurlas.CommunicationWithNeurons
{
    class DrawingNeurons
    {

        public DrawingNeurons()
        {

        }

        public void DrawCollection(Graphics g, List<Neuron> neurons)
        {
            foreach(var _neuron in neurons)
                g.FillEllipse(new SolidBrush(_neuron.BackColor), _neuron.recNeuron.X, _neuron.recNeuron.Y, _neuron.recNeuron.Width, _neuron.recNeuron.Height);
        }
    }
}
