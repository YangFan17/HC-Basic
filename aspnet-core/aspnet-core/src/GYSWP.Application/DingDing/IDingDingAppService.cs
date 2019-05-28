﻿using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GYSWP.DingDing
{
    public interface IDingDingAppService : IApplicationService
    {
        string GetAccessToken(string appkey, string appsecret);

        string GetUserId(string accessToken, string code);
    }
}
