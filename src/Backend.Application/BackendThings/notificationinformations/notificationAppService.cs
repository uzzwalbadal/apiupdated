using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Backend.BackendThings.notificationinformations.dto;
using Backend.EntityModels.noti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BackendThings.notificationinformations
{
    [AbpAuthorize]
    public class notificationAppService : AsyncCrudAppService<NotificationModel, dto_notificationmodel, int, PagedResultRequestDto, dto_notificationmodel, dto_notificationmodel>
    {
        private readonly IRepository<FcmNotificationSetting, int> _notiRepo;
        public notificationAppService(IRepository<FcmNotificationSetting, int> repository) : base((IRepository<NotificationModel, int>)repository)
        {
            _notiRepo = repository;
        }
        public ListResultDto<dto_FcmNoti> GetAllNotificationWIthServerKey(PagedResultRequestDto input)
        {
            var result = _notiRepo.GetAll().Select(q => new dto_FcmNoti()
            {
                Id = q.Id,
                SenderId = q.SenderId,
                ServerKey = q.ServerKey,
                
            });

            return new ListResultDto<dto_FcmNoti>(result.Skip(input.SkipCount).Take(input.MaxResultCount).ToList());
        }
    }
}
