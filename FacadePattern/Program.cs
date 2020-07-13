namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new VideoConverter();

            var mp4 = converter.Convert("test.ogg", "mp4");

            mp4.Save();
        }
    }
}