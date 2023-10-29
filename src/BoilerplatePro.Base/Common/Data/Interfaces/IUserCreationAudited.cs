#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Users.Entities;

namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IUserCreationAudited : ICreationAudited, IHasCreationTime
    {
        /// <summary>Reference to the creator user of this entity.</summary>
        User CreatorUser { get; set; }
    }
}