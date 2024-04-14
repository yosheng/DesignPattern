namespace CreatePattern.SimpleFactoryPattern;

/*
 * 下靣一个比较简单常见的抽出方法来管理角色的方法，但是 if else 重复撰写，可以尝试使用简单工场模式优话
 */

/// <summary>
/// 角色管理员
/// </summary>
public class RoleManager
{
    private readonly string _type;

    public RoleManager(string type)
    {
        this._type = type;
    }

    public int? GetPermissionNumber()
    {
        if (this._type.Equals("admin"))
        {
            return 0;
        }
        else if (this._type.Equals("system"))
        {
            return 1;
        }
        else if(this._type.Equals("user"))
        {
            return 2;
        }
        else
        {
            return null;
        }
    }

    public bool IsSuperPower()
    {
        if (this._type.Equals("admin"))
        {
            return true;
        }
        else if (this._type.Equals("system"))
        {
            return true;
        }
        else if(this._type.Equals("user"))
        {
            return false;
        }
        else
        {
            return false;
        }
    }
}