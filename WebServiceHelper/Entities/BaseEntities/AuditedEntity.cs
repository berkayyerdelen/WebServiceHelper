using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceHelper.Entities.BaseEntities
{
    public abstract class AuditedEntity<T>
    {
        public T Id { get; set; }
    }
}
