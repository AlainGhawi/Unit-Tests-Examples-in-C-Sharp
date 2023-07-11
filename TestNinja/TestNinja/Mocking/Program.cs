namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}
