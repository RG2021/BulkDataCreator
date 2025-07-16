using Microsoft.Xrm.Sdk;
using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mockit.Services
{
    public class DataGenService
    {
        private readonly IOrganizationService _service;
        public DataGenService(IOrganizationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        

    }
}