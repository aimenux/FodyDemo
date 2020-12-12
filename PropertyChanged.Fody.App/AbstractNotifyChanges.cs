using System;
using System.ComponentModel;

namespace PropertyChanged.Fody.App
{
    public class AbstractNotifyChanges : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName, object before, object after)
        {
            PrintPropertyChanges(propertyName, before, after);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private static void PrintPropertyChanges(string propertyName, object before, object after)
        {
            ConsoleColor.Green.WriteLine($"Property = '{propertyName}'");
            ConsoleColor.Yellow.WriteLine($" -> Before = '{before}'");
            ConsoleColor.Yellow.WriteLine($" -> After = '{after}'");
        }
    }
}
