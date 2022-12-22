namespace GameStore.Web.Client.Pages
{
    public class StandardOptions
    {
        public string Name { get; set; }
    }
    public class MyOptions : StandardOptions
    {
        public string Id { get; set; }
    }

    public class MyOptions2 : StandardOptions
    {
        public string Id2 { get; set; }
    }

    public class InheritanceExamples
    {
        public void DoStuff()
        {
            StandardOptions options;
            options = new MyOptions2();
            var actualOptions = options as MyOptions;
            
        }
    }

}
