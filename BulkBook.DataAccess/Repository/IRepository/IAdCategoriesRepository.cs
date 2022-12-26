﻿using BulkBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBook.DataAccess.Repository.IRepository
{
    public interface IAdCategoriesRepository:IRepository<AdCategories>
    {
    void Update(AdCategories obj);
  }
}
