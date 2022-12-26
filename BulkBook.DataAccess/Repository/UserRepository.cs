﻿using BulkBook.DataAccess.Repository.IRepository;
using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    private ApplicationDbContext _db;

    public UserRepository(ApplicationDbContext db):base(db)
    {
      _db= db;
    }

    public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
