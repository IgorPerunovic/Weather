using System;
using System.Drawing;
using Acr.UserDialogs;

//using Acr.UserDialogs;

namespace Weather.Services
{
    public class ToastService : IToastService
    {
        
        public void ShowMessage(string message, double time) // ideally, in a bigger app there would be different messages for various needs,
                                                             // but in this instance we just needed this for error messages.
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
