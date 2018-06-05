using System;


namespace DialogTDD.Portable.Authorization.Auth_View.Interfaces
{
    public interface IAuth_View
    {
        event Action<string, string> OnSignInClick;
        event Action OnRegistrationClick;
        event Action<bool> ChangeLocalizationClick;

        void SetLabelLoginText(string labelLogin);
        void SetLabelPasswordText(string LabelPassword);
        void SetButtonSignInText(string buttonSignInText);
        void SetButtonRegistrationText(string buttonRegistrationText);
    }
}
