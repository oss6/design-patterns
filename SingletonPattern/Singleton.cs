namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance() => _instance ?? (_instance = new Singleton());
    }
}
