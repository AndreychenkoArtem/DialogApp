using DialogTDD.Portable.Authorization.Auth_Interactor.Interfaces;
using DialogTDD.Portable.Authorization.Auth_Presenter.Interfaces;
using DialogTDD.Portable.Data;
using DialogTDD.Portable.Data.Interfaces;
using System;


namespace DialogTDD.Portable.Authorization.Auth_Interactor
{
    public class Auth_Interactor : IAuth_Interactor
    {
        private IAuth_Presenter _auth_Presenter;
        private IDataWrap _dataWrap;

        public Auth_Interactor(IDataWrap data)
        {
            throw new NotImplementedException();
            // _dataWrap = data?? throw new ArgumentNullException();
        }

        public IAuth_Presenter Auth_Presenter
        {
            get => _auth_Presenter;
            set
            {
                if (_auth_Presenter != null)
                {
                    _auth_Presenter.OnSignInPressed -= SignInPressed;
                    _auth_Presenter.OnRegistrationPressed -= RegistrationPressed;
                }
                _auth_Presenter = value ?? throw new ArgumentNullException();
                _auth_Presenter.OnSignInPressed += SignInPressed;
                _auth_Presenter.OnRegistrationPressed += RegistrationPressed;
            }
        }



        public void RegistrationPressed()
        {
            throw new NotImplementedException();
            //_auth_Presenter.GoToRegistration();
        }

        private bool Validation()
        {
            throw new NotImplementedException();
            //return true;
        }


        public void SignInPressed()
        {
            throw new NotImplementedException();
            //_auth_Presenter.GoToChat();
        }

        public IAuth_Entity GetDataFromUser(string login, string password)
        {
            //string loginEntity = login;
            //string passwordEntity = password;
            //IAuth_Entity auth_EntityFromUser = new Auth_Entity(loginEntity, passwordEntity);
            //return auth_EntityFromUser;
            throw new NotImplementedException();
        }
    }
}
