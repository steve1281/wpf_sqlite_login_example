using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SQlite_Login_Example
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var Username = txtUserName.Text;
            var Password = txtPassword.Password;

            using (UserDataContext context = new UserDataContext())
            {
                bool userfound = context.Users.Any(user => user.Name == Username && user.Password == Password);
                if (userfound)
                {
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
        }

        public void GrantAccess()
        {
            MainPage main = new MainPage();
            main.Show();
        }
    }
}
