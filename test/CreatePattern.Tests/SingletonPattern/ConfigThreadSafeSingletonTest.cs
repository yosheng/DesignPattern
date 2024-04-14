using CreatePattern.SingletonPattern;

namespace CreatePattern.Tests.SingletonPattern;

public class ConfigThreadSafeSingletonTest
{
    [Fact]
    public void Test()
    {
        // 创建一个Task数组来存放10个任务
        var tasks = new Task[10];

        // 启动10个任务并填充到Task数组中
        for (var i = 0; i < 10; i++)
        {
            var index = i;
            tasks[i] = Task.Run(() =>
            {
                var instance = ConfigThreadSafeSingleton.Instance;
                var data = index.ToString();
                instance.AddConfig(new(data, data));
            });
        }

        Task.WaitAll(tasks);
        Assert.Equal(10, ConfigThreadSafeSingleton.Instance.GetAllConfig().Count);
    }
}