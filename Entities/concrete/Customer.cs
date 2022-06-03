﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.concrete
{
    public class Customer:IEntities
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}