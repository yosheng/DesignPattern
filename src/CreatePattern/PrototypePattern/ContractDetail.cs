using System.Text.Json;

namespace CreatePattern.PrototypePattern;

public class ContractDetail : ICloneable
{
    public string Name { get; set; }

    public string Owner { get; set; }

    public string Signatory { get; set; }

    public List<string> Terms { get; set; }

    public object Clone()
    {
        /*
         * 使用 [Serializable] 序列化来克隆对象并不安全
         * BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter
         */
        // var bf = new BinaryFormatter();
        // var ms = new MemoryStream();
        // bf.Serialize(ms, this);
        // ms.Position = 0;
        // return bf.Deserialize(ms);

        /*
         * 使用 Json 序列化来克隆对象，但会出现空值警告
         * JsonSerializer.Serialize 效率略低
         */
        var resultBytes = JsonSerializer.SerializeToUtf8Bytes(this);
        return JsonSerializer.Deserialize<ContractDetail>(new ReadOnlySpan<byte>(resultBytes))!;
    }
}