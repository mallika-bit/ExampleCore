using ExampleCore.Utility;
using System;

namespace ExampleCore.Areas.Admin.Controllers
{
    internal class AuthorizationAttribute : Attribute
    {
        public SD Roles { get; set; }
    }
}