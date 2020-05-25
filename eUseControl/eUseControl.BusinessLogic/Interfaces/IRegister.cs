using eUseControl.Domain.Entites.User;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface IRegister
    {
        URegisterResp UserRegister(URegisterData data);
    }
}