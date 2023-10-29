#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Users.Entities;

namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IUserModificationAudited : IModificationAudited
    {
        /// <summary>Reference to the last modifier user of this entity.</summary>
        User LastModifierUser { get; set; }
    }
}