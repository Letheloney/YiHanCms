﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YiHan.Cms.Web.Models.TenantRegistration
{
    public class TenantRegisterResultViewModel
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public bool IsActive { get; set; }

        public bool IsEmailConfirmationRequired { get; set; }
    }
}