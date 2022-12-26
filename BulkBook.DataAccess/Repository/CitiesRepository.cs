using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class CitiesRepository:Repository<Cities>,ICitiesRepository
    {
    private ApplicationDbContext _db;
    public CitiesRepository(ApplicationDbContext db):base(db)
    {
      _db= db;
    }

  }
}
