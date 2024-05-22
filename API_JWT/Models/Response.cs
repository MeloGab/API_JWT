namespace API_JWT.Models
{
    public class Response<T>
    {
        public T? Date { get; set; }
        public string Mensage { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
