namespace MyWeb.Data
{
    public class ResponseViewModel
    {
        public bool Success { get; set; }
        public string Message { get; set; } = "";
        public  object? Data { get; set; }

        public object? AdditionalData { get; set; }
    }
}
