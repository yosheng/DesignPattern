using BehaviorPattern.MediatorPattern.Role;

namespace BehaviorPattern.MediatorPattern;

public class RoleMediator : Mediator
{
    public Leader Leader { get; set; }
    public Doctor Doctor { get; set; }
    public Nurse Nurse { get; set; }
    
    public override void Prepare(RoleBase role)
    {
        if (role == Leader)
        {
            Console.WriteLine("领导来了!");
            Doctor.Doing();
            Nurse.Doing();
        }

        if (role == Doctor)
        {
            Console.WriteLine("医生来了!");
            Nurse.Doing();
        }
        
        if (role == Nurse)
        {
            Console.WriteLine("护士来了!");
        }
    }
}