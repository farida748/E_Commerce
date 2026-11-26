using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Common
{
    public abstract class BaseEntity <TKey>
    {
        public int id { get; set; } = default!;
    }
}
