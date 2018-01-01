namespace ThreeInOne.dto.request
{
    using RestSharp;

    public class BaseRequest
    {
        public string router { set; get; }
        public Method method { set; get; }
    }
}