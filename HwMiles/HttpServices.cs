namespace HwMiles
{
    public class EPAService
    {
        public readonly HttpClient httpClient;

        public EPAService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetBaseUrl()
        {
            return httpClient.BaseAddress.ToString();
        }
    }

    class HWMilesService
    {
        public readonly HttpClient httpClient;

        public HWMilesService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetBaseUrl()
        {
            return httpClient.BaseAddress.ToString();
        }

    }
}
