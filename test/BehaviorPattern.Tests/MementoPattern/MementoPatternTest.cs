using BehaviorPattern.MementoPattern;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.MementoPattern;

public class MementoPatternTest : XunitContextBase
{
    public MementoPatternTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test()
    {
        var medicalRecord = new MedicalRecord
        {
            Title = "张三",
            Content = "张三的病历"
        };
        
        var medicalRecordCaretaker = new MedicalRecordCaretaker();
        medicalRecordCaretaker.Memo = medicalRecord.Save();
        
        medicalRecord.Title = "李四";
        medicalRecord.Content = "李四的病历";
        
        medicalRecord.Restore(medicalRecordCaretaker.Memo);
        
        Output.WriteLine($"Title: {medicalRecord.Title}");
        Output.WriteLine($"Content: {medicalRecord.Content}");
    }
}