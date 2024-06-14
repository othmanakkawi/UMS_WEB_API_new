﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;

namespace UMS_DAL.Repositories.Majors
{
    public interface IMajorRepository : IGenericRepository<Major>
    {
        IEnumerable<Major> GetMajorByFacultyId(int id);
    }
}
