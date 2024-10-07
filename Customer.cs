
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace U7Offer
{
    delegate void AgeChanged();
    internal class Customer : INotifyPropertyChanged
    {
        int age;
        string firstname;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Lastname { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public Customer(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            //MessageBox.Show($"Property is changed");
        }

        public override string ToString()
        {
            return $"Vorname, Name: {Firstname}, {Lastname} , Alter: {Age}";
        }


    }
}
