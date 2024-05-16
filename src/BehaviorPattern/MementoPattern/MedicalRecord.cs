namespace BehaviorPattern.MementoPattern;

/// <summary>
/// Originator 发起者
/// </summary>
public class MedicalRecord
{
    public string Title { get; set; }

    public string Content { get; set; }

    public MedicalRecordMemo Save()
    {
        return new MedicalRecordMemo(Title, Content);
    }

    public void Restore(MedicalRecordMemo memo)
    {
        Title = memo.Title;
        Content = memo.Content;
    }
}