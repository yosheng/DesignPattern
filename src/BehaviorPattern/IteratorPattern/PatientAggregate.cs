namespace BehaviorPattern.IteratorPattern;

public class Patient
{
    public string Name { get; set; }

    public int Age { get; set; }
}

public class PatientAggregate : Aggregate<Patient>
{
    public PatientAggregate(List<Patient> data) : base(data)
    {
    }

    public override IIterator CreateIterator()
    {
        return new PatientIterator(this);
    }
}