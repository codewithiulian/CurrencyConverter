using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_technical_test.Models
{
    public class Currency
    {
        public double SourceAmount { get; set; }
        public string SourceCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public double? Result { get; set; }

        public Currency()
        {

        }
    }
}
