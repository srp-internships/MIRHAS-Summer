namespace Practice.Models.Responce
{
    public class ServiceResponce<T>
    {
        public T? Data { get; set; }
        public bool Succes { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }

    public class ServiceResponce
    {
        public bool Succes { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
