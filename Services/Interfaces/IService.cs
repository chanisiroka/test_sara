using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IService<T>
    {
    public  Task< List<T>> getAllAsync();
    public Task <T> getByIdAsync(int id);
    public Task <T> AddAsync(T T);
    public Task <T> UpdateAsync(T T);
    public Task DeleteAsync(int id);
    }
}
