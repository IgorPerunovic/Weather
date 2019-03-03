using System;
using System.Drawing;
using Acr.UserDialogs;

//using Acr.UserDialogs;

namespace Weather.Services
{
    public class ToastService : IToastService
    {
        
        public void ShowMessage(string message, double time)
        {

            var toastConfig = new ToastConfig(message)
            {
                Message = message,
                BackgroundColor = Color.OrangeRed,
                Duration = TimeSpan.FromSeconds(time),
                MessageTextColor = Color.White,
            };

            var toast = UserDialogs.Instance.Toast(toastConfig);
            toast.Dispose();

        }
    }
}
