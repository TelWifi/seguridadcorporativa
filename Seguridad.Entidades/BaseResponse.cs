namespace Seguridad.Entidades
{
    public class BaseResponse
    {
        public Result Resultado { get; set; }

        public BaseResponse()
        {
            Resultado = new Result();
        }
    }
}
