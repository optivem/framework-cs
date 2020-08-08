﻿using Atomiv.Template.Infrastructure.Domain.Persistence.MongoDB.Records;
using MongoDB.Driver;

namespace Atomiv.Template.Infrastructure.Domain.Persistence.MongoDB
{
    public class MongoDBContext
    {
        public MongoDBContext(IDbSettings settings)
        {
            // TODO: VC: Remove this when reading config works
            settings.ConnectionString = "mongodb://localhost:27017";
            settings.DatabaseName = "WebShopDb";

            Client = new MongoClient(settings.ConnectionString);
            Database = Client.GetDatabase(settings.DatabaseName);

            Customers = Database.GetCollection<CustomerRecord>(CollectionNames.Customers);
            Products = Database.GetCollection<ProductRecord>(CollectionNames.Products);
            Orders = Database.GetCollection<OrderRecord>(CollectionNames.Orders);
        }

        public IMongoClient Client { get; }

        public IMongoDatabase Database { get; }

        public IMongoCollection<CustomerRecord> Customers { get; }

        public IMongoCollection<ProductRecord> Products { get; }

        public IMongoCollection<OrderRecord> Orders { get; }
    }
}
