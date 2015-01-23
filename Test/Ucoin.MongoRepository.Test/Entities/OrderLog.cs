﻿using System;
using Ucoin.Framework.Entities;

namespace Ucoin.MongoRepository.Test
{
    public class OrderLog : LongKeyMongoEntity
    {
        public int OrderId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime? CreatedBy { get; set; }
    }
}