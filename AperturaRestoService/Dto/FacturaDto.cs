using System;
using System.Collections.Generic;

namespace AperturaRestoService.Dto
{
    public class FacturaDto
    {
        public FacturaDto()
        {
            Detalle = new List<FacturaRenglonDto>();
        }
        public int ComandaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string CodigoCliente { get; set; }
        public string RazonSocial { get; set; }
        public string Email { get; set; }
        public double Descuento { get; set; }
        public double Recargo { get; set; }
        public double Propina { get; set; }
        public double Total { get; set; }
        public String Estado { get; set; }
        public String TComp { get; set; }
        public String NComp { get; set; }
        public int CodigoCaja { get; set; }
        public String DescripcionCaja { get; set; }
        public String Terminal { get; set; }
        public IList<FacturaRenglonDto> Detalle { get; set; }
    }
}
