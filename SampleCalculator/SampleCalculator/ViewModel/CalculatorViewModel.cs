using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using SampleCalculator.Model;

namespace SampleCalculator.ViewModel
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        private Model.CalcuratorModel _calculator { get; set; }

        public int First
        {
            get
            {
                return this._calculator.First;
            }
            set
            {
                this._calculator.First = value;
                this.OnPropertyChanged("First");
            }
        }

        public int Second
        {
            get {
                return this._calculator.Second;
            }
            set
            {
                this._calculator.Second = value;
                this.OnPropertyChanged("Second");
            }
        }

        public int Answer
        {
            get
            {
                return this._calculator.Answer;
            }
        }

        public string Color
        {
            get
            {
                string color;
                switch (_calculator.Color)
                {
                    case Model.Color.Red:
                        color = "赤";
                        break;
                    case Model.Color.Green:
                        color = "緑";
                        break;
                    case Model.Color.Blue:
                        color = "青";
                        break;
                    case Model.Color.Yelow:
                        color = "黄色";
                        break;
                    default:
                        color = "無色";
                        break;
                }
                return color;
            }
        }

        private MyCommand _calculateCommand;
        public MyCommand Calculate{
            get
            {
                return this._calculateCommand;
            }
        }
        private MyCommand _clearCommand;
        public MyCommand Clear
        {
            get
            {
                return this._clearCommand;
            }
        }

        public CalculatorViewModel()
        {
            this._calculator = new CalcuratorModel();
            this._calculateCommand = new MyCommand(commandName: "計算" , action: ()=> { this._calculator.Calculate(); this.OnPropertyChanged("Answer"); });
            this._clearCommand = new MyCommand(commandName: "クリア", action: () =>
            {
                _calculator.Clear();
                this.OnPropertyChanged("First");
                this.OnPropertyChanged("Second");
                this.OnPropertyChanged("Answer");
            });
        }

        private void test()
        {
            this._calculator.Calculate();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}