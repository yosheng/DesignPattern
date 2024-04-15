using CreatePattern.SimpleFactoryPattern;

namespace CreatePattern.FactoryMethodPattern;

public interface IRoleFactory
{
    IRole? CreateRole();
}