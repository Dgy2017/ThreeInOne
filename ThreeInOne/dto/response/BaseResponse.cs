namespace ThreeInOne.dto.response
{
    public class BaseResponse<T>
    {
        public int code { get; set; }
        public T data { get; set; }
        public string message { get; set; }
    }
}