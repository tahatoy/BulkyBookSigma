using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class AdsRepository : Repository<Ads>, IAdsRepository
    {
    private ApplicationDbContext _db;

    public AdsRepository(ApplicationDbContext db):base(db) {
      _db= db;
    }
    public void update(Ads obj)
        {
            throw new NotImplementedException();
        }
    }
}
