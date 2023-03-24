﻿using DataSense.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Repository
{
    internal interface Repository<ID, E> where E : Entity<ID>
    {
        E findOne(ID id);

        List<E> findAll();

        E save(E entity);

        E delete(ID id);

        E update(E entity, E newEntity);
    }
}
