﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;

namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IHasCreationTime
    {
        /// <summary>Creation time of this entity.</summary>
        DateTime Created { get; set; }
    }
}