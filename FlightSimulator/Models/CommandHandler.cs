﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.Models {
    //Command Handler
    public class CommandHandler : ICommand {
        private Action _action;
        public CommandHandler(Action action) {
            _action = action;
        }
        public bool CanExecute(object parameter) {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter) {
            _action();
        }
    }
}
