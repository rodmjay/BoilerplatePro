﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion


namespace BoilerplatePro.Base.Geography.Interfaces
{
    public interface IStateProvince
    {
        string Name { get; set; }
        string Abbrev { get; set; }
        string Code { get; set; }
    }
}