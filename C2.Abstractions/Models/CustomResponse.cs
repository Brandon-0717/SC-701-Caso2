
namespace C2.Abstractions.Modelos
{
    public class CustomResponse <T>
    {
        public bool IsError { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public CustomResponse()
        {
            IsError = false;
            Message = "Acción realizada con éxito.";
        }
    }
}
