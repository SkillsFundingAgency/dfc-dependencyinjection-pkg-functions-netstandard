using System;
using Microsoft.Azure.WebJobs.Description;

namespace DFC.Functions.DI.Core.Attributes
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute
    {
    }
}