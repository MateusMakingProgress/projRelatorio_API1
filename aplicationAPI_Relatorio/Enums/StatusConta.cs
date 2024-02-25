using System.ComponentModel;

namespace aplicationAPI_Relatorio.Enums
{
    public enum StatusConta
    {
        [Description("A pagar")]
        Pagar = 1,
        [Description("Pago")]
        Pago = 2,
    }
}
