using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCleanArchitecture.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
