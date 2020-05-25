using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entites.User;



namespace eUseControl.BusinessLogic
{
    public class RegisterBL : UserApi, IRegister
    {
        public URegisterResp UserRegister(URegisterData data)
        {
            return UserRegisterAction(data);
        }
    }
}
