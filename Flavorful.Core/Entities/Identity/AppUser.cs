﻿namespace Flavorful.Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public UserAddress Address { get; set; }
    }
}
