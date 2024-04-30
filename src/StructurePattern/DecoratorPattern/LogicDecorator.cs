namespace StructurePattern.DecoratorPattern;

public abstract class LogicDecorator : LogicComponent
{
    protected readonly Logic Logic;

    protected LogicDecorator(Logic logic)
    {
        Logic = logic;
    }
}