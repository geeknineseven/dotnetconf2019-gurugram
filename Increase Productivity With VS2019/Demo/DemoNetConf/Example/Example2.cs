using Newtonsoft.Json;

namespace DemoNetConf.Example
{
    public class Example2
    {
        public void Foo(string name, object obj)
        {
            int i = 0;
            JsonConvert.SerializeObject(obj);
        }
    }
}
