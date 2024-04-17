using MAUIUI.Business.Abstract;
using MAUIUI.Business.DependencyResoulver.AutofacResoulver;
using MAUIUI.Core.Entities;

namespace MAUIUI.Views
{
    public partial class LoginPage : ContentPage
    {
        User? _user;
        IUserService _userService;
        public LoginPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _user = new User();


        }

        private async void Button_Login_Clicked(object sender, EventArgs e)
        {




            _user = _userService.GetByEmail(Entry_Username.Text).Data;
            if (1 == 1 || _user != null)
            {
                if (1 == 1 || _userService.Login(Entry_Username.Text, Entry_Password.Text, _user).Success)
                {
                    if (1 == 1 || _user.KVKK1 == "Yes" && _user.KVKK2 == "Yes" && _user.KVKK3 == "Yes" && _user.KVKK4 == "Yes")
                    {
                        _user = new User{ UserName="a"};
                        try { 
                        var n= Navigation.PushAsync(new HomePage(_user)).IsCompleted;
                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                    /*else
                    {
                        await DisplayAlert("kvvk", "kvvk Eklenecek", "ok");
                    }*/
                }
                else
                {
                    await DisplayAlert("kvvk", "kvvk Eklenecek", "ok");
                }

            }
            else
            {
                await DisplayAlert("Error", "Enter a valid user name", "Ok");
            }
        }

        private void ChangePassword_Tapped(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new ChangePasswordPage());
        }

        private void Button_Login_SizeChanged(object sender, EventArgs e)
        {
            double deneme = Button_Login.FontSize;
        }
    }

}
