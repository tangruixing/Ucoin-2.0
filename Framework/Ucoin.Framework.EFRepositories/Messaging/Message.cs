﻿namespace Ucoin.Framework.SqlDb.Messaging
{
    using System;

    public class Message
    {
        public Message(string body, DateTime? deliveryDate = null, string correlationId = null)
        {
            this.Body = body;
            this.DeliveryDate = deliveryDate;
            this.CorrelationId = correlationId;
        }

        public string Body { get; private set; }

        public string CorrelationId { get; private set; }

        public DateTime? DeliveryDate { get; private set; }
    }
}
