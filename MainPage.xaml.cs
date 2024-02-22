using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONAssignment
{
    public partial class MainPage : ContentPage
    {
        /* private string _name;

         public string Name
         {
             get { return _name; }
             set { _name = value;

                 OnPropertyChanged();
             }
         }

         private string _lastname;

         public string LastName
         {
             get { return _lastname; }
             set { _lastname = value; 

                 OnPropertyChanged();
             }
         }

            private string _emailaddress;

         public string EmailAddress
         {
             get { return _emailaddress; }
             set { _emailaddress = value; 

                 OnPropertyChanged();
             }
         }

            private string _bio;

         public string Bio
         {
             get { return _bio; }
             set { _bio= value; 

                 OnPropertyChanged();
             }
         }
        */

        private Profile _profile;
        public Profile CurrentProfile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();

            //CurrentProfile = LoadData();

            BindingContext = this;

        }




        #region Buttons

        public void SaveProfile(Profile profile)
        {
           string _fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
           string FullFile = Path.Combine(_fileName, "Profile.txt");
           string json = JsonConvert.SerializeObject(profile);
           File.WriteAllText(_fileName, json);
           SaveButton.Text = File.ReadAllText(_fileName);
        }

        public Profile LoadData() 
        {
            string _fileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string FullFile = Path.Combine(_fileName, "Profile.txt");

            string FileContent = File.ReadAllText(FullFile);

            Profile currentprofile = JsonConvert.DeserializeObject<Profile>(FileContent);
            return currentprofile;
        }

    private void SaveButton_Clicked(object sender, EventArgs e)
        {
           SaveProfile(this.CurrentProfile);
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        
        #endregion Buttons
    }
}
