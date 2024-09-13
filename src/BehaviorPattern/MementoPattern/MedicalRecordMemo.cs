namespace BehaviorPattern.MementoPattern;

public class MedicalRecordMemo
{
    public string Title { get; private set; }

    public string Content { get; private set; }

    public MedicalRecordMemo(string title, string content)
    {
        Title = title;
        Content = content;
    }
}