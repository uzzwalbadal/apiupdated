using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.EntityModels.noti
{
    public class FcmNotificationSetting : FullAuditedEntity<int>
    {
        
        public string SenderId { get; set; }
        public string ServerKey { get; set; }
    }
}

