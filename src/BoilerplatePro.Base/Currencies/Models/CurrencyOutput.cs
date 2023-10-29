using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoilerplatePro.Base.Currencies.Interfaces;

namespace BoilerplatePro.Base.Currencies.Models
{
    public class CurrencyOutput : ICurrency
    {
        public string Code { get; set; }
        public string Decimals { get; set; }
        public string Name { get; set; }
    }
}
