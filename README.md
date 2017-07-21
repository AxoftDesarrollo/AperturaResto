#Bienvenido a Apertura Resto 
Esta aplicacion es un servidor externo donde Resto se comunica con él para mandar información en ciertos comportamientos.

##Requerimientos para desarrollar
1.	Abrir el proyecto AperturaRestoService
2.	Configurar la url y el puerto que se desea para levantar el servidor http en la clase Service1.cs en el método OnStar. 
		var config = new HttpSelfHostConfiguration("http://localhost:9100");
3.	Compilarlo y registrar el servicio en windows.
4.	Configurar en Resto la url y el puerto del servidor http para la AperturaResto. (Nota: la descripción de la url irá sin http)

##LOGS
Solamente el servicio tiene configurado LOGFORNET. El log de ejecucion se puede consultar en C:\ProgramData\Axoft\AperturaResto

##Implementación
* La clase ComandaController.cs en el método AfterSend se ejecutará al enviar a cocina los renglones de una comanda.
* La clase FacturaController.cs en el método AfterInsert se ejecutará al factuarar una comanda o generar una nota de crédito.

## Clases
####FacturaDto
    public int ComandaId { get; set; }
    public DateTime Fecha { get; set; }
    public string Hora { get; set; }
    public string CodigoCliente { get; set; } ()
    public string RazonSocial { get; set; }
    public string Email { get; set; }
    public double Descuento { get; set; }
    public double Recargo { get; set; }
    public double Propina { get; set; }
    public double Total { get; set; }
    public String Estado { get; set; }
    public String TComp { get; set; } (Tipo de comprobante)
    public String NComp { get; set; } (Número de comprobante)
    public IList<FacturaRenglonDto> Detalle { get; set; }
####FacturaRenglonDto
	public int NumeroRenglon { get; set; }
    public double Cantidad { get; set; }
    public String CodigoArticulo { get; set; }
    public String DescripcionArticulo { get; set; }
    public double Precio { get; set; }
    public double Importe { get; set; }
####ComandaDto
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
####ComandaRenglonDto
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
####Estados de una comanda.
    Abierta = 'A';
    Anulada = 'X';
    Cobrada = 'C';
    Facturada = 'F';
    Cerrada = 'E';
    Cerrada cuenta corriente = 'T';
    A cerrar cuenta corriente = 'R';
    Despachada = 'S';
    Despachada y cobrada = 'P';
    Cancelada con tickets tipo Sodexho = 'V';
####Estados de un renglon de una comanda
    Ingresado = 'I';
    Pasado = 'P';
    BloqueoImp = 'B';
    Devuelto = 'D';
    Anulado = 'X';