using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public interface IWorkWithFiles
    {
        void Save(List<MBall> balls, string FilePath);
        List<MBall> Load(string FilePath);
    }
}
