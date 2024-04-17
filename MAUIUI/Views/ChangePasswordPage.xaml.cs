using System;
using Microsoft.Maui.Controls;

namespace MAUIUI.Views
{
    public partial class ChangePasswordPage : ContentPage
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
        }

        private async void ChangePasswordButton_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string oldPassword = OldPasswordEntry.Text;
            string newPassword = NewPasswordEntry.Text;
            string confirmNewPassword = ConfirmNewPasswordEntry.Text;

            // Eğer yeni şifreler eşleşmiyorsa veya gerekli alanlar doldurulmamışsa hata göster
            if (newPassword != confirmNewPassword)
            {
                await DisplayAlert("Error", "New passwords do not match.", "OK");
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
            }
            else
            {
                // Şifre değiştirme işlemi burada yapılacak
                // Örnek olarak, şu anda sadece bir mesaj gösteriyoruz
                await DisplayAlert("Success", "Password changed successfully.", "OK");

            }

        }
    }
}
