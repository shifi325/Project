﻿using Blood_Bank.Core.Entities;
using Blood_Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Service
{
    public class SicksService
    {
        private readonly ISicksRepositories _sicksRepositories;
        public SicksService(ISicksRepositories sicksRepositories)
        {
            _sicksRepositories = sicksRepositories;
        }
        public IEnumerable<Sicks> GetAll()
        {
            return _sicksRepositories.GetAll();
        }
        public Sicks Get(int id)
        {
            return _sicksRepositories.Get(id);

        }

        public void Post(Sicks sic)
        {
            _sicksRepositories.Post(sic);

        }


        public void Put(int id, Sicks sic)
        {
            _sicksRepositories.Put(id, sic);
        }


        public void Delete(int id)
        {
            _sicksRepositories.Delete(id);
            
        }
    }
}

