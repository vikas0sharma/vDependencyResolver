using System.Collections.Generic;

namespace Contracts
{
    public interface IValueService
    {
        IEnumerable<string> GetValues();
    }
}
