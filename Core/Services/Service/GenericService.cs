using Core.Services.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
   public  class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entities;
        private readonly WebContext _context;
        protected GenericService(WebContext context)
        {
            _entities = context.Set<TEntity>();
            _context = context;
        }
        /// <summary>
        /// Adds an item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Add(TEntity entity)
        {
            try
            {
                _entities.Add(entity);
               var result= await _context.SaveChangesAsync();
                if (result > 0)
                {
                    return "Success";
                }
               
            }
            catch (Exception er)
            {
                return er.Message;
            }
            return "false";

        }
        /// <summary>
        /// Deletes an item 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>string</returns>
        /// 


        public async Task<string> Delete(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return "Success";
            }
            catch (Exception er)
            {
                return er.Message;
            }
        }

        /// <summary>
        /// Get All Items
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }


        /// <summary>
        /// Returns a number of items
        /// Lambda Expression
        /// </summary>
        /// <param name="predicate">Lambda Expression</param>
        /// <returns>Returns a number of items</returns>
        public async Task<IEnumerable<TEntity>> GetByIdAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Returns a single item out of the list of items
        /// Lambda Expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>Single Object</returns>
        public async Task<TEntity> GetSingleAsync(Guid? id)
        {
            return await _entities.FindAsync(id);
        }

        /// <summary>
        /// Edits an item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>string</returns>
        public async Task<string> Edit(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return "Success";
            }
            catch (Exception er)
            {
                return er.Message;
            }
        }

        public async Task<TEntity> GetSingleAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.SingleOrDefaultAsync(predicate);
        }
    }
}
