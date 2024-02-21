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
        Profile profile = new Profile();   
        public class Profile
        { }
            public string Name;
            public string LastName;
            public string EmailAddress;
            public string Bio;
            public string json;
            public string Name
            {
                get => Name;

                set
                {
                    Name = value;
                    OnPropertyChanged();
                }
            }

            public string Lastname
            {
                get => Lastname;

                set
                {
                    LastName = value;
                    OnPropertyChanged();
                }
            }

            public string Emailaddress
            {
                get => Emailaddress;

                set
                {
                    EmailAddress = value;
                    OnPropertyChanged();
                }
            }

            public string Bio
            {
                get => Bio;

                set
                {
                    Bio = value;
                    OnPropertyChanged();
                }
            }
            #endregion Profile Data
        
        #region Buttons

      
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(Profile);
            File.WriteAllText(_fileName, json);
            SaveButton.Text= File.ReadAllText(_fileName);
         
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {
            Profile deserializedprofile = JsonConvert.DeserializeObject<Profile>(json);
            File.ReadAllText(_fileName);
        }

        #endregion Buttons
    }
}
