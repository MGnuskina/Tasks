using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class FormData : INotifyPropertyChanged
    {
        private int lineWidth;
        public int LineWidth
        {
            get { return this.lineWidth; }
            set {
                this.lineWidth = value;
                NotifyPropertyChanged("LineWidth");
            }
        }

        IList<int> lineWidthList;
        public IList<int> LineWidthList
        {
            get { return this.lineWidthList; }
            set
            {
                if (value != lineWidthList)
                {
                    lineWidthList = value;
                    NotifyPropertyChanged("LineWidth");
                }
            }
        }

        private string type;
        public string Type {
            get { return this.type; }
            set
            {
                this.type = value;
                NotifyPropertyChanged("Type");
            }
        }

        IList<string> typeList;
        public IList<string> TypeList
        {
            get { return this.typeList; }
            set
            {
                if (value!=typeList)
                {
                    typeList = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate (object sender, PropertyChangedEventArgs args) { };

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
