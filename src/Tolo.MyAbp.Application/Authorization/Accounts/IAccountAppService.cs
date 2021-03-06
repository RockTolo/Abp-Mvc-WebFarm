﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Tolo.MyAbp.Authorization.Accounts.Dto;

namespace Tolo.MyAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
