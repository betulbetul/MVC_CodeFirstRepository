﻿using MVC_CodeFirst.Entity.Models;
using MVCCodeFirst.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCodeFirst.BLL.Repository
{
    public abstract class RepositoryBase<T, ID> : IDisposable where T : Temel<ID>
    {
        protected static MyContext dbContext;
        public async virtual Task<List<T>> GetAll()
        {
            try
            {
                dbContext = new MyContext();
                return await dbContext.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async virtual Task<T> GetById(ID id)
        {
            try
            {
                dbContext = new MyContext();
                return await dbContext.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async virtual void Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Add(entity);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                dbContext.Set<T>().Remove(entity);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async virtual void Update()
        {
            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual IQueryable<T> Queryable()
        {
            try
            {
                dbContext = dbContext ?? new MyContext();
                return dbContext.Set<T>().AsQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
            dbContext = null;
        }
        public void Dispose(bool isDispose = true)
        {
            if (isDispose)
                this.Dispose();
        }
    }
}

