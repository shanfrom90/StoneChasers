﻿using Microsoft.EntityFrameworkCore;
using Sailing_Rocks.Extensions;
using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Repositories
{
    public class Repository<T> : IRepository<T> where T : class

    {
        private DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }
        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            Save();
        }

        public Rock GetRockBySerial(string serial)
        {
            return db.Set<Rock>().Where(r => r.Serial == serial).FirstOrDefault();
        }

        public LoginResult CheckLogin(string username, string password)
        {
            var user = db.Set<User>().Where(u => u.UserName == username && u.Password == Helpers.Helper.EncryptPassword(password)).FirstOrDefault();

            if (user == null)
            {
                return new LoginResult() { Result = false, Message = "No such user could be found.", User = null };
            }
            else
            {
                return new LoginResult() { Result = true, Message = "", User = user };
            }

        }
    }
}
