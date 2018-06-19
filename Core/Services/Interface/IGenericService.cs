using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Interface
{
    public interface IGenericService<T> where T : class
    {
        //Get All
        Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// Returns a single item out of the list of items
        /// Lambda Expression
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Single Object</returns>
        Task<T> GetSingleAsync(Guid? id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetSingleAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// Adds an item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<string> Add(T entity);
        /// <summary>
        /// Deletes an item 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>string</returns>
        Task<string> Delete(T entity);
        /// Edits an item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>string</returns>
        Task<string> Edit(T entity);
        /// <summary>
        /// Returns a number of items
        /// Lambda Expression
        /// </summary>
        /// <param name="predicate">Lambda Expression</param>
        /// <returns>Returns a number of items</returns>
        Task<IEnumerable<T>> GetByIdAsync(Expression<Func<T, bool>> predicate);
    }
}
