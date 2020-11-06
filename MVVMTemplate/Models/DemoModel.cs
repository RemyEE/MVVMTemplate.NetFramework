using MvvmFoundation.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMTemplate.Models
{
    public class DemoModel : ObservableObject
    {
        #region Properties

        #region Public
        public string MyString
        {
            get { return myString; }
            set
            {
                if (value.Equals(myString))
                {
                    return;
                }

                myString = value;
                RaisePropertyChanged("MyString");
            }
        }

        public int MyNumber
        {
            get { return myNumber; }
            set
            {
                if (value.Equals(myNumber))
                {
                    return;
                }

                myNumber = value;
                RaisePropertyChanged("MyNumber");
            }
        }
        #endregion

        #endregion

        #region Fields

        #region Private
        private string myString;
        private int myNumber;
        #endregion

        #endregion
    }
}
