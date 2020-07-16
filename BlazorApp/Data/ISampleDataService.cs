using System.Collections.Generic;

namespace BlazorApp.Data
{
    public interface ISampleDataService
    {
        List<string> GetMilkshakeSizes();
        List<string> GetMilkshakeTypes();
    }
}