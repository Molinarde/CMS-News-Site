﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Models
{
    public interface IRepository
    {
        IEnumerable<News> News();
    }
}
