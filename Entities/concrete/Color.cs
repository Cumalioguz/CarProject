using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Color : IEntities
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
