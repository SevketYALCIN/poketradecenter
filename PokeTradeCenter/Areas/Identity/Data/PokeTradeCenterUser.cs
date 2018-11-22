using System;
using Microsoft.AspNetCore.Identity;

namespace PokeTradeCenter.Areas.Identity.Data
{
    public class PokeTradeCenterUser : IdentityUser
    {
        [PersonalData]
        public string Nickname { get; set; }
        [PersonalData]
        public string FriendId { get; set; }
    }
}