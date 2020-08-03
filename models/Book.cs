using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.models
{
    public class Book
    {
        [BsonId]
        public ObjectId _Id { get; set; }
        public int ISBN { get; set; }
        public string Name { get; set; }

        public string Publisher { get; set; }

        public int Price { get; set; }

    }
}
