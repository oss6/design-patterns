namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private readonly ExternalApi _api;

        public Adapter(ExternalApi api)
        {
            _api = api;
        }
        
        public string GetRequest()
        {
            return $"This is '{_api.GetSpecificRequest()}'";
        }
    }
}