using LMS_1.Contracts;
using LMS_1.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS_1.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class //Expect to interact with database
    {
        private readonly ApplicationDbContext context;


        //create a constructor that injects data into the repository(same principle as the injecting data into the constructor
        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id); //Set<T>() is the method to generalise inputs
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = GetAsync(id);
            return entity != null;

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();

        }
    }
}
