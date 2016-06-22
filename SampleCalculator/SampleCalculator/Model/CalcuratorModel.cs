using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SampleCalculator.Model
{
    class CalcuratorModel : INotifyPropertyChanged
    {
        public int First { get; set; }

        public int Second { get; set; }

        public int Answer { get; set; }

        public Operator Operator { get; set; }
        
        public Color Color { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Calculate()
        {
            switch (Operator)
            {
                case Operator.Add:
                    Answer = First + Second;
                    break;
                case Operator.Subtract:
                    Answer = First - Second;
                    break;
                case Operator.Multiply:
                    Answer = First * Second;
                    break;
                default:
                    Clear();
                    break;
            }
            this.OnPropertyChanged("Answer");
        }

        public void Clear()
        {
            Answer = 0;
            First = 0;
            Second = 0;
        }
    }

    public enum Operator
    {
        Add,
        Subtract,
        Multiply
    }

    public enum Color
    {
        Red,
        Blue,
        Green,
        Yelow
    }
}
