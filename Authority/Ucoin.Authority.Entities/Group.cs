﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ucoin.Framework.Entities;
using Ucoin.Framework.SqlDb.Entities;

namespace Ucoin.Authority.Entities
{
    public class Group : EfEntity<int>, IAggregateRoot<int>, IOperateEntity<string>
    {
        public string Name { get; set; }

        public int ParentId { get; set; }

        public byte Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
