using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class AddressRepository:Repository<Address>,IAddressRepository
    {
    private ApplicationDbContext _db;
    public AddressRepository(ApplicationDbContext db):base(db)
    {
      _db= db;
    }

        public void Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}
