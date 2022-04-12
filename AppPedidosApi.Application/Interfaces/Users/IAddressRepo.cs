using AppPedidosApi.Domain.Entities.Users;

namespace AppPedidosApi.Application.Interfaces.Users
{
    public interface IAddressRepo
    {
        Address AddAddress(Address adsress);
        List<Address> GetAddressByUserId(Guid id);
        Address EditAddress(Guid id);
        Address DisableAddress(Guid id);
    }
}
