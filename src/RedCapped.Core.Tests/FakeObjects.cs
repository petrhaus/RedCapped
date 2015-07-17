﻿using MongoDB.Bson;
using MongoDB.Driver;

namespace RedCapped.Core.Tests
{
    public class FakeRedCappedQueueManager : QueueManager
    {
        public FakeRedCappedQueueManager(IMongoContext mongoContext)
            : base(mongoContext)
        {

        }
    }

    public class FakeQueueOf<T> : QueueOf<T>
    {
        public FakeQueueOf(IMongoCollection<Message<T>> collection, IMongoCollection<BsonDocument> safeCollection, IMongoCollection<BsonDocument> errorCollection)
            : base(collection, safeCollection, errorCollection)
        {

        }
    }
}
