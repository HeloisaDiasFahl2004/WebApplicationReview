using MongoDB.Bson.Serialization.Attributes;

namespace WebApplicationReview.Models
{
    public class Cachorro
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Apelido { get; set; }
    }
}
