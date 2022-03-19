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
    [AutoMap(typeof(NotificationModel))]
    public class dto_notificationmodel : EntityDto<int>
    {



        public string DeviceId { get; set; }

        public bool IsAndroiodDevice { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
   
}
       
    

