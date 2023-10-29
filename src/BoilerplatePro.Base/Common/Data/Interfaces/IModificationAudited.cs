#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion


namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IModificationAudited : IHasModificationTime
    {
        /// <summary>Last modifier user for this entity.</summary>
        int? LastModifierUserId { get; set; }
    }
}