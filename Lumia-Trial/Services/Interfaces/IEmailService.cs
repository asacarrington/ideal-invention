﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lumia_Trial.Models;

namespace Lumia_Trial.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(CompanyViewModel mode);
    }
}
