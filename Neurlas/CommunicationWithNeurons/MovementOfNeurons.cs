using Neurlas.neuron;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurlas.CommunicationWithNeurons
{
    class MovementOfNeurons
    {
        public MovementOfNeurons()
        {

        }

        public void Moving(ref List<Neuron> neuronsCollection, float X, float Y)
        {
            for(int i = 0; i < neuronsCollection.Count; i++)
            {
                var point = new PointF(neuronsCollection[i].X + -X, neuronsCollection[i].Y + -Y);
                neuronsCollection[i] = new Neuron(point, neuronsCollection[i].Size);
            }
        }

        public PointF DirectionSide(float oldValueX, float oldValueY, float newValueX, float newValueY) // определение направления движения
        {
            float valueX = newValueX - oldValueX;
            float valueY = newValueY - oldValueY;

            return new PointF(valueX, valueY);
        } 
    }
}
