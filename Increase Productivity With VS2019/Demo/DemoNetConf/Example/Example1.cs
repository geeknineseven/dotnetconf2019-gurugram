namespace DemoNetConf.Example
{
    public class Example1
    {
        public void Foo()
        {
            int i = 0;
            var val = i switch
            {
                1 => "val1",
                2 => "val2",
                3 => "val3",
                _ => "val1",
            };
        }
    }
}
