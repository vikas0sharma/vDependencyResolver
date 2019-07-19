# vDependencyResolver

MEF based dependency resolver for Asp.Net Core projects.
You can download the package from [Nuget](https://www.nuget.org/packages/vDependencyResolver/)


# Introduction

Generally we declare all dependencies in Startup.cs which generally leads to hundreds of lines dependency registration. 
It couples the application tightly to all dependencies. Web project has to include reference of contracts but also their actual implementations.
Typically a web project refers service layer contracts project and also service layer implementation project.

By, using MEF we can move the registrations for dependencies away from the Startup.cs file into the individual DependencyResolvers that live alongside the implementation of the service.


# Usage

Create Dependency resolver class in your service project itself.

``` csharp

    [Export(typeof(IDependencyResolver))]
    public class MyServiceDependencyResolver : IDependencyResolver
    {
        public void SetUp(IDependencyRegister dependencyRegister)
        {
            dependencyRegister.AddScoped<IMyService, MyService>();
        }
    }

```

In Startup.cs by simply one line specifies the path of the dlls and dll name.

``` csharp
    services.LoadDependencies(@".\bin\Debug\netcoreapp2.0", "Services.dll");

```
