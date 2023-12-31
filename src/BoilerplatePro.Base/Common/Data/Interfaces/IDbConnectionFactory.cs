﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Data;

namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection DbConnection { get; }
    }
}