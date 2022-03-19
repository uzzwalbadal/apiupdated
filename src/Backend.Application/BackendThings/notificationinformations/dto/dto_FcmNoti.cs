using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Backend.EntityModels.noti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.notificationinformations.dto
{
    [AutoMap(typeof(FcmNotificationSetting))]
    public class dto_FcmNoti : EntityDto<int>
    {
        public string SenderId { get; set; }
        public string ServerKey { get; set; }
    }
}
