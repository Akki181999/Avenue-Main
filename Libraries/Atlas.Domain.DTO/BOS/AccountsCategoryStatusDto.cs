using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Atlas.Common.Utils.BackOfficeEnum;

namespace Atlas.Domain.DTO.BOS
{
    public class AccountsCategoryStatusDto
    {
        public BO_ObjectAPI accountObject { get; set; }
        public int NewStatusId { get; set; }
    }
}
