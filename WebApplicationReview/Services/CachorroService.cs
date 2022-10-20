using MongoDB.Driver;
using System.Collections.Generic;
using WebApplicationReview.Models;
using WebApplicationReview.Utils;

namespace WebApplicationReview.Services
{
    public class CachorroService
    {
        public readonly IMongoCollection<Cachorro> _cachorro;
        public CachorroService(IDatabaseSettings settings)
        {
            var con = new MongoClient(settings.ConnectionString);
            var database = con.GetDatabase(settings.DatabaseName);
            _cachorro = database.GetCollection<Cachorro>(settings.CachorroCollectionName);
        }
        public Cachorro Create(Cachorro cachorro)
        {
            _cachorro.InsertOne(cachorro);
            return cachorro;
        }
        public List<Cachorro> GetAll() => _cachorro.Find<Cachorro>(cachorro => true).ToList();

        public Cachorro GetByName(string nome) => _cachorro.Find<Cachorro>(cachorro => cachorro.Nome == nome).FirstOrDefault();

        
    }
}
