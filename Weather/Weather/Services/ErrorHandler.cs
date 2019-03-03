using System;
using Xamarin.Forms;

namespace Weather.Services
{
    public static class ErrorHandler // of course, this is very rudimental, but the principle is there, we have a class to handle errors
        // it calls on toast service to display error messages, in a more complicated app it would do other error-handling things too
    {
        private static int ERROR_MESSAGE_DURATION = 3;
        public static IToastService ToastService => DependencyService.Get<IToastService>() ?? new ToastService();
        public static void HandleGenericError(Exception e)
        {
            ToastService.ShowMessage("There was an error: "+e.Message, ERROR_MESSAGE_DURATION);
        }

        public static void HandleGenericAPIError(Exception e)
        {
            ToastService.ShowMessage("There was an error connecting to the server, please try again later", ERROR_MESSAGE_DURATION);
        }

        public static void HandleGenericGPSError(Exception e)
        {
            ToastService.ShowMessage("There was an error with the GPS service, please check that your GPS is enabled", ERROR_MESSAGE_DURATION);
        }

    }
}
