using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CasualWord.Helper
{
    public class SimpleCommand : ICommand
    {
        Action _execute;
        public SimpleCommand(Action execute)
        {
            this._execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
