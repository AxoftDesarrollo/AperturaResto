using System;
using System.Collections.Generic;

namespace AperturaRestoService.Dto
{
    public class ComandaDto
    {
        public ComandaDto()
        {
            Detalle = new List<ComandaRenglonDto>();
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
        public IList<ComandaRenglonDto> Detalle { get; set; }
    }
}
