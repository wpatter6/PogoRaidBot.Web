using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PogoRaidBot.Web.Data.Entities
{
    public class OAuthCodeEntity
    {
        public ulong Id { get; set; }
        public string Code { get; set; }
    }
}
