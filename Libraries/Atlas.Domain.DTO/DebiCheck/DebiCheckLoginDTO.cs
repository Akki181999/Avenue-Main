using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebiCheck
{
    public class DebiCheckLoginDTO
    {
        public Int64 DebiCheckLoginId { get; set; }

        public string MerchantId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime DeletedDT { get; set; }

        public int CredentialPurposeFlags { get; set; }

        public string AccessLevel { get; set; }
    }
}
