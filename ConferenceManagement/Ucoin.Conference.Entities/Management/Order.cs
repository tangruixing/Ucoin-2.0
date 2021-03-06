﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ucoin.Framework.Entities;
using Ucoin.Framework.SqlDb.Entities;

namespace Ucoin.Conference.Entities
{
    public class Order : EfEntity<Guid>, IAggregateRoot<Guid>
    {
        public enum OrderStatus
        {
            Pending,
            Paid,
        }

        public Order(Guid conferenceId, Guid orderId, string accessCode)
            : this()
        {
            this.Id = orderId;
            this.ConferenceId = conferenceId;
            this.AccessCode = accessCode;
        }

        protected Order()
        {
            this.Seats = new ObservableCollection<OrderSeat>();
        }

        public Guid ConferenceId { get; set; }

        /// <summary>
        /// Used for correlating with the seat assignments.
        /// </summary>
        public Guid? AssignmentsId { get; set; }

        [Display(Name = "Order Code")]
        public string AccessCode { get; set; }

        [Display(Name = "Registrant Name")]
        public string RegistrantName { get; set; }

        [Display(Name = "Registrant Email")]
        public string RegistrantEmail { get; set; }

        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// This pattern is typical for EF 4 since it does 
        /// not support native enum persistence. EF 4.5 does.
        /// </summary>
        [NotMapped]
        public OrderStatus Status
        {
            get { return (OrderStatus)this.StatusValue; }
            set { this.StatusValue = (int)value; }
        }

        public int StatusValue { get; set; }

        public ICollection<OrderSeat> Seats { get; set; }
    }
}
