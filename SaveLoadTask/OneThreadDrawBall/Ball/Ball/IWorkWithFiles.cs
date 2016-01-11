using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    public interface IWorkWithFiles
    {
        void Save(List<BouncingBallClass> balls, string FilePath);
        List<BouncingBallClass> Load(string FilePath);
    }
}
