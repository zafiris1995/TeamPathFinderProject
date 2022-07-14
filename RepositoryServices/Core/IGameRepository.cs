﻿using Project123;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();

    }
}
