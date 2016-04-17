﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComInLan
{
    interface IServer
    {
        Guid Id { get; }
        string DomainId { get; }
        string Name { get; }   
        int ListeningPort { get; }
    }
}