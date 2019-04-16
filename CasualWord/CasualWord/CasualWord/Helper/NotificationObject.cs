using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasualWord.Helper
{
    public class NotificationObject : INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //protected virtual void SetProperty<T>(ref T member, T val,
        //    [CallerMemberName] string propertyName = null)
        //{
        //    if (object.Equals(member, val)) return;

        //    member = val;
        //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetProperty<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }


    }
}
