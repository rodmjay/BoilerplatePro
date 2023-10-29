#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using AutoMapper;
using BoilerplatePro.Base.Users.Entities;
using BoilerplatePro.Base.Users.Models;

namespace BoilerplatePro.Base.Users.Projections
{
    public class UserProjections : Profile
    {
        public UserProjections()
        {
            CreateMap<User, UserDto>()
                .IncludeAllDerived();
        }
    }
}