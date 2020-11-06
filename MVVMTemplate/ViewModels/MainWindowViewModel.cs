using MvvmFoundation.Wpf;
using MVVMTemplate.Models;
using System;
using System.Windows.Input;

namespace MVVMTemplate.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        #region Constructor
        public MainWindowViewModel()
        {
            TheModel = new DemoModel
            {
                MyString = "Binding works!",
                MyNumber = 0,
            };
        }
        #endregion

        #region Properties

        #region Public
        public DemoModel TheModel
        {
            get
            {
                return theModel;
            }
            set
            {
                if (value.Equals(theModel))
                {
                    return;
                }

                theModel = value;
                RaisePropertyChanged("TheModel");
            }
        }

        public ICommand CountCommand
        {
            get
            {
                return new RelayCommand(this.OnCountCommand, () => this.CanCount);
            }
        }
        #endregion

        #region Internal
        internal bool CanCount
        {
            get
            {
                return true;
            }
        }
        #endregion

        #endregion

        #region Methods

        #region Public
        public void OnCountCommand()
        {
            TheModel.MyNumber++;
        }
        #endregion

        #endregion

        #region Fields

        #region Private
        private DemoModel theModel;
        #endregion

        #endregion
    }
}
