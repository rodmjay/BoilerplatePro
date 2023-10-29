#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoilerplatePro.Api.Interfaces;

public interface IIdentityController
{
    Task<Dictionary<string, List<string>>> GetCurrentIdentity();
}