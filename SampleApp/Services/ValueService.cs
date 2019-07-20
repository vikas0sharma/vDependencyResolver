using Contracts;
using System.Collections.Generic;

namespace Services
{
    public class ValueService : IValueService
    {
        public IEnumerable<string> GetValues()
        {
            return new List<string> { "Value1", "Value2", "Value3" };
        }
    }
}
