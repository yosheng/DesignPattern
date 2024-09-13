﻿namespace StructurePattern.CompositePattern.Scenario1;

public class DepartmentItem : GroupComponent
{
    public override string Name { get; }
    public override string Code { get; }

    public DepartmentItem(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public override void Operation()
    {
        Console.WriteLine($"{Name} - {Code} 查询科室用户中...");
    }
}