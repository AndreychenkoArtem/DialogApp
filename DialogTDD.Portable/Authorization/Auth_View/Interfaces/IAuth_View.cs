using System;


namespace DialogTDD.Portable.Authorization.Auth_View.Interfaces
{
    public interface IAuth_View
    {
        event Action<string, string> OnSignInClick;
        event Action OnRegistrationClick;
        event Action<bool> ChangeLocalizationClick;

        void SetMainLabelText(string mainLabel); //Test+
        void SetLabelLoginText(string labelLogin); //Test+
        void SetLabelPasswordText(string LabelPassword); //Test+
        void SetButtonSignInText(string buttonSignInText); //Test+
        void SetButtonRegistrationText(string buttonRegistrationText); //Test+
    }
}
