using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using TestCSharp.Business.Models;
using TestCSharp.Interfaces;
using TestCSharp.Models;

namespace TestCSharp.Database
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly IMongoCollection<T> _collection;

        public Repository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["Mongo:ConnectionString"]);
            var database = client.GetDatabase(configuration["Mongo:Database"]);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }

        public async Task<T> Create(T entity)
        {
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.Now;
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<T> Update(Guid id, T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            await _collection.ReplaceOneAsync<T>(e => e.Id == id, entity);
            return entity;
        }

        public async Task<T> GetById(Guid id)
        {
            return (await _collection.FindAsync(e => e.Id == id)).FirstOrDefault();
        }

        public async Task Delete(Guid id)
        {
            await _collection.DeleteOneAsync<T>(e => e.Id == id);
        }       

        public IEnumerable<T> Listar()
        {
            return _collection.AsQueryable<T>();
        }
    }
}