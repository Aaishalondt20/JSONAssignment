using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONAssignment
{
    public class  Profile : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private string _lastname;
        public string LastName
        {
            get { return _lastname; }

            set
            {
                _lastname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));

            }
        }

        private string _emailaddress;
        public string EmailAddress
        {
            get { return _emailaddress; }

            set
            {
                _emailaddress = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmailAddress)));
            }
        }

        private string _bio;
        public string Bio
        {
            get { return _bio; }

            set
            {
                _bio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bio)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


    }
}
