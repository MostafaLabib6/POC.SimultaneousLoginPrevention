﻿using OCR.SimultaniousLogin;
using Volo.Abp.Users;

namespace ConcurrentLogin;

public static class CurrentUserExtensions
{
    public static string GetConcurrentLoginToken(this ICurrentUser currentUser)
    {
        return currentUser.FindClaimValue(SimultaniousLoginConsts.ConcurrentLoginToken);
    }
}
