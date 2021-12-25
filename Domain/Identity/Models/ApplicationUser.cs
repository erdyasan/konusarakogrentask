﻿using Domain.Catalog.Quiz;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity.Models;
public class ApplicationUser:IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
