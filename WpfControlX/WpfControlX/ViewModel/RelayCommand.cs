using System;
using System.Windows.Input;

namespace WpfControlX.ViewModel

{
    public class RelayCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute execute;
        private ICommandOnCanExecute canExecute;
        private object executerunNormalize;
        private object canExcuteRunNormalize;

        public RelayCommand(ICommandOnExecute onExecuteMethod, ICommandOnCanExecute onCanExecuteMethod)
        {
            execute = onExecuteMethod;
            canExecute = onCanExecuteMethod;
        }

        public RelayCommand(object executerunNormalize, object canExcuteRunNormalize)
        {
            this.executerunNormalize = executerunNormalize;
            this.canExcuteRunNormalize = canExcuteRunNormalize;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }

        #endregion
    }
}
