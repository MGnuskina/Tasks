using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public class BallsOriginator
    {
        public List<BBControl> balls;

        public BallsOriginator()
        {
            balls = new List<BBControl>();
        }

        public void SetMemento(BallsMemento memento)
        {
            balls.Clear();
            List<MBall> mBalls = memento.GetMemento();
            foreach(MBall ball in mBalls)
            {
                balls.Add(new BBControl(ball.X, ball.Y, ball.Dx, ball.Dy, ball.Width, ball.Height));
            }
        }

        public BallsMemento CreateMemento()
        {
            List<MBall> mBalls = new List<MBall>();
            foreach(BBControl ball in balls)
            {
                mBalls.Add(new MBall(ball.Location.X, ball.Location.Y, ball.dx, ball.dy, ball.Width, ball.Height));
            }
            return new BallsMemento(mBalls);
        }
    }
}
