using AppPedidosApi.Application.Interfaces.Users;
using AppPedidosApi.Context;
using AppPedidosApi.Domain.Entities.Users;

namespace AppPedidosApi.Infra.Repositories
{
    public class AddressRepo : IAddressRepo
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        public Address AddAddress(Address address)
        {
            _db.Adresses.Add(address);
            _db.SaveChanges();
            return address;
        }

        public Address DisableAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        public Address EditAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAddressByUserId(Guid id)
        {
            return _db.Adresses.Where(a => a.CustomerId == id).ToList();
        }
    }
}
