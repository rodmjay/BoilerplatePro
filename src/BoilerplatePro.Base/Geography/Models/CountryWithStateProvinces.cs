﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Collections.Generic;

namespace BoilerplatePro.Base.Geography.Models
{
    public class CountryWithStateProvinces : CountryDto
    {
        public CountryWithStateProvinces()
        {
            StateProvinces = new List<StateProvinceDto>();
        }

        public List<StateProvinceDto> StateProvinces { get; set; }
    }
}