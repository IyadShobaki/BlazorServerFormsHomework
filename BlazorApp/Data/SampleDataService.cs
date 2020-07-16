using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class SampleDataService : ISampleDataService
    {
        public List<string> GetMilkshakeTypes()
        {
            return new List<string>
            {
                "Chocolate",
                "Vanilla",
                "Peanut Butter",
                "Strawberry"
            };
        }
        public List<string> GetMilkshakeSizes()
        {
            return new List<string>
            {
                "Small",
                "Medium",
                "Large",
                "Extra Large"
            };
        }
    }
}
