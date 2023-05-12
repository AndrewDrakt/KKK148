using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPdaraye.ViewModel.Helpers
{
    internal class bilding /*: INotifyPropertyChanged*/
    {
        public event PropertyChangedEventHandler property;
        protected void OnPropertyChanched([CallerMemberName] string name = null)
        {
          /*  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));*/
        }
    }
}