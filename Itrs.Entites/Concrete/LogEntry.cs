﻿using Itrs.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Entites.Concrete
{
    public class LogEntry : IEntity
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }
    }
}
