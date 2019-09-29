namespace DemoNetConf.Example
{
    /// <summary>
    /// <c>public static void Main(string[] args)</c><para></para>
    /// <em>Something</em><para></para>
    /// <para>
    /// <see href="https://www.sourabhsomai.com"/>
    /// </para>
    /// <list type="bullet">
    /// <item><description>Something 1</description></item>
    /// <item><description>Something 2</description></item>
    /// <item><description>Something 3</description></item>
    /// <item><inheritdoc/></item>
    /// </list>
    /// </summary>
    public interface ITweetAlert
    {
        void Mehotd();
    }
    ///<inheritdoc cref="ITweetAlert"/>
    public class TweetAlert : ITweetAlert
    {
        public virtual void Mehotd()
        {

        }
    }
    public class MyAlert : TweetAlert, ITweetAlert
    {
        public override void Mehotd()
        {
            TweetAlert a = new TweetAlert();
        }
        static void StaticMethod(string a, string b, string c)
        {

        }
    }
}
