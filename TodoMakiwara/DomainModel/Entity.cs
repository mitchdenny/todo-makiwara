﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoMakiwara.DomainModel
{
    public abstract class Entity
    {
        public Entity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; protected set;
    }
}
