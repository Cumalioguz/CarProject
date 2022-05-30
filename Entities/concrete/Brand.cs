using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Brand : IEntities
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
