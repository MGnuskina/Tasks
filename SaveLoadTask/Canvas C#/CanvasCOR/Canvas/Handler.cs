using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public abstract class Handler
    {
        protected APictureSL successor;

        public void SetSuccessor(APictureSL successor)
        {
            this.successor = successor;
        }

        public abstract APictureSL GetHandler(string extention);//
    }
}
