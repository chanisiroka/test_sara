using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Interfaces
{
  public  interface IRepository<T>
    {
        Task<List<T>> getAllAsync();
        Task<T> getByIdAsync(int id);
        Task<T> AddAsync(int id, string name, string desc);

        Task<T> UpdateAsync(T T);
        Task DeleteAsync(int id);
    }
}
