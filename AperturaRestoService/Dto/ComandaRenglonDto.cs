using System;

namespace AperturaRestoService.Dto
{
    public class ComandaRenglonDto
    {
        public int NumeroRenglon { get; set; }
        public double Cantidad { get; set; }
        public String CodigoArticulo { get; set; }
        public String DescripcionArticulo { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
        public DateTime FechaEnvio { get; set; }
        public String HoraEnvio { get; set; }
        public int NumeroRenglonPadre { get; set; }
        public String Estado { get; set; }
    }
}
