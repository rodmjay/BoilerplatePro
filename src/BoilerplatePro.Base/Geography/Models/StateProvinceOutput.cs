#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Geography.Interfaces;

namespace BoilerplatePro.Base.Geography.Models
{
    public class StateProvinceOutput : IStateProvince
    {
        public string Name { get; set; }

        public string Abbrev { get; set; }

        public string Code { get; set; }
    }
}