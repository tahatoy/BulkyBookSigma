using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class DeadlineRepoistory:Repository<Deadline>,IDeadlineRepository
    {
    private ApplicationDbContext _db;
    public DeadlineRepoistory(ApplicationDbContext db):base(db)
    {
      _db= db;
    }
  }
}
