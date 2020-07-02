using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace seg.core.Models
{
    public class _BaseModel : INotifyPropertyChanged
    {
        /* Clint Landry
         * We want the Mutator of all model properties to impliment
         * InotifyProperty changed in order for the UI to know when
         * a property has changed without having to set INotifyProperty changed
         * on each and every property that is backing a UI element. It might seem 
         * redudant but when you drill down for example into a collection bound
         * to a list view and bind to a collection item's individual properties
         * the thing notifying of a change is actually the model itself.    
         */

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
