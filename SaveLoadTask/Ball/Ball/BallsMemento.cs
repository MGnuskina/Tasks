using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public class BallsMemento
    {
        private List<MBall> balls;

        public BallsMemento(List<MBall> balls)
        {
            this.balls = new List<MBall>(balls);
        }

        public List<MBall> GetMemento()
        {
            return balls;
        }
    }
}
