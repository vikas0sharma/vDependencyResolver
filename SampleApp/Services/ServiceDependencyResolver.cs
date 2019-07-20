using Contracts;
using System.ComponentModel.Composition;
using vDependencyResolver;

namespace Services
{
    [Export(typeof(IDependencyResolver))]
    public class ServiceDependencyResolver : IDependencyResolver
    {
        public void SetUp(IDependencyRegister dependencyRegister)
        {
            dependencyRegister.AddTransient<IValueService, ValueService>();
        }
    }
}
