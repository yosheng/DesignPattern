using System.Collections.Generic;
using BehaviorPattern.IteratorPattern;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.IteratorPattern;

public class IteratorPatternTest : XunitContextBase
{
    public IteratorPatternTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test()
    {
        var patientAggregate = new PatientAggregate(new List<Patient>
        {
            new Patient
            {
                Name = "张三",
                Age = 18
            },
            new Patient
            {
                Name = "李四",
                Age = 20
            },
            new Patient
            {
                Name = "王五",
                Age = 22
            }
        });
        
        var patientIterator = patientAggregate.CreateIterator();
        
        while (!patientIterator.IsLast())
        {
            var patient = (Patient) patientIterator.CurrentItem();
            Output.WriteLine($"Name: {patient.Name}");
            Output.WriteLine($"Age: {patient.Age}");
            patientIterator.Next();
        }
    }
}