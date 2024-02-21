using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONAssignment
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "profile_creation.txt");
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext= this;
        }
        #region Profile Data

        
            public string _name
            {
                get => _name;

                set
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }

            public string _lastname
            {
                get => _lastname;

                set
                {
                    _lastname = value;
                    OnPropertyChanged();
                }
            }

            public string _emailaddress
            {
                get => _emailaddress;

                set
                {
                    _emailaddress = value;
                    OnPropertyChanged();
                }
            }

            public string _bio
            {
                get => _bio;

                set
                {
                    _bio = value;
                    OnPropertyChanged();
                }
            }
            #endregion Profile Data
        
        #region Buttons

      
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Profile profile = new Profile();
         
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {

        }

        #endregion Buttons
    }
}
