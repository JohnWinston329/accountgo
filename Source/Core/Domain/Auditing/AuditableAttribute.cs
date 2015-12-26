﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Auditing
{
    [Table("AuditableAttribute", Schema = "dbo")]
    public class AuditableAttribute : BaseEntity
    {
        [Key]
        public int AuditableAttributeId { get; set; }
        public int AuditableEntityId { get; set; }
        public string AttributeName { get; set; }
        public bool EnableAudit { get; set; }
        public virtual AuditableEntity AuditableEntity { get; set; }
    }
}
