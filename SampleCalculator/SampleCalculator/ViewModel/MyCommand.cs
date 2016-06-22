using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleCalculator.ViewModel
{
    class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action _action;

        public string commandName { get; set; }

        public MyCommand(Action action, string commandName = "")
        {
            this._action = action;
            this.commandName = commandName;
        }

        bool ICommand.CanExecute(object parameter)
        {
            return true;
        }

        void ICommand.Execute(object parameter)
        {
            _action();
        }
    }
}
