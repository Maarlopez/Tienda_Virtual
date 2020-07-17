using System;

namespace Integrador
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		ListaProductos listaproductos=new ListaProductos(); /* Creo una nueva instancia del tipo ListaProductos */
		Carro carrito=new Carro(); // Creo una nueva instancia del tipo Carro
		ListaTarjetas lista_tarjetas=new ListaTarjetas(); // Creo una nueva instancia del tipo ListaTarjetas
		ListaClientes clientes=new ListaClientes(); //Creo una nueva instancia del tipo ListaClientes
		double TotalTienda; //defino una variable para almacenar el total vendido
		
		public Menu() /* Constructor por defecto */
		{
		}
		
		public void Principal(){ 
			
			int op;
			do{ /* Implemento un Do While para que el menú se ejecute al menos una vez */
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                    TIENDA LA MUNDIAL ON-LINE                      *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿A qué módulo desea ingresar?\n"); /* Muestro el menú */
				
				Console.WriteLine("1) Productos Y Promociones");
				Console.WriteLine("2) Compras");
				Console.WriteLine("3) Tarjetas de credito");
				Console.WriteLine("4) Administracion");
				Console.WriteLine("5) Salir");
				
				op = int.Parse(Console.ReadLine()); /* Parseo el dato ingresado por el usuario para pasarlo 
				de string a entero */
				
				switch(op){ /* Inicializo el menu con un switch */
						
					case 1:
						ModuloProducto(); //llamo al método ModuloProducto de esta misma clase
						break;
					case 2:
						ModuloCompras();
						break;
					case 3:
						ModuloTarjetas();
						break;
					case 4:
						Administracion();
						break;
					case 5:
						break;
					default:
						Console.WriteLine("Opcion incorrecta"); /* Agrego una opción más en caso de que se ingrese
						un numero fuera de rango */
						break;
				}
	
				}while(op!=5);							
			}
		
		
		public void ModuloProducto(){ /* Creo un nuevo método llamado ModuloProducto */
			
			
			int op;
			do{
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                           MÓDULO PRODUCTOS                        *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿Que desea hacer?\n");
				
				Console.WriteLine("1) Dar de alta productos");
				Console.WriteLine("2) Dar de alta promociones");
				Console.WriteLine("3) Listar Productos");
				Console.WriteLine("4) Listar promociones");
				Console.WriteLine("5) Volver");
				
				op = int.Parse(Console.ReadLine());
				
				switch(op){
						
					case 1:
						listaproductos.Agregar();
						break;
					case 2:
						listaproductos.AgregarDescuento(); /* invoco AgregarDescuento de la clase ListaProductos */
						break;
					case 3:
						listaproductos.Imprimir();
						Console.ReadKey();
						break;
					case 4:
						listaproductos.ImprimirProm();
						Console.ReadKey();
						break;
					case 5:
						break;
					default:
						Console.WriteLine("Opcion incorrecta");
						break;
				}
		
				}while(op!=5);
				
								
			}
		
		public void ModuloCompras(){ /* Creo un nuevo método llamado ModuloCompras */
			
			
			int op;
			do{
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                           MÓDULO COMPRAS                          *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿Que desea hacer?\n");
				
				Console.WriteLine("1) Carro de compras");
				Console.WriteLine("2) Identificar Cliente");
				Console.WriteLine("3) Volver");
				
				op = int.Parse(Console.ReadLine());
				
				switch(op){
						
					case 1:
						SubmoduloCarro();
						break;
					case 2:
						ventas();
						break;
					case 3:
						break;
					default:
						Console.WriteLine("Opcion incorrecta");
						break;
				}
						
						
						
				}while(op!=3);
				
								
			}
		
		public void SubmoduloCarro(){ /* Creo un nuevo método llamado SubmoduloCarro */
			
			
			int op;
			do{
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                        SUBMÓDULO CARRO                            *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿Que desea hacer?\n");
				
				Console.WriteLine("1) Agregar producto al carro");
				Console.WriteLine("2) Quitar producto del carro");
				Console.WriteLine("3) Listar productos del carro");
				Console.WriteLine("4) Volver");
				
				op = int.Parse(Console.ReadLine());
				
				switch(op){
						
					case 1:
						carrito.Agregar(listaproductos);
						break;
					case 2:
						carrito.Quitar();
						break;
					case 3:
						carrito.ListaCarrito();
						Console.ReadKey();
						break;
					case 4:
						break;
					default:
						Console.WriteLine("Opcion incorrecta");
						break;
				}
						
						
						
				}while(op!=4);
				
								
			}
		public void ModuloTarjetas(){ /* Creo un nuevo método llamado ModuloTarjetas */
			
			
			int op;
			do{
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                  MÓDULO TARJETAS DE CREDITO                       *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿Que desea hacer?\n");
				
				Console.WriteLine("1) Dar de alta tarjeta de crédito");
				Console.WriteLine("2) Dar de alta beneficios para las tarjetas");
				Console.WriteLine("3) Listar tarjetas de crédito");
				Console.WriteLine("4) Listar tarjetas de crédito con beneficios");
				Console.WriteLine("5) Volver");
				
				op = int.Parse(Console.ReadLine());
				
				switch(op){
						
					case 1:
						lista_tarjetas.AgregarTarjeta();
						break;
					case 2:
						lista_tarjetas.AgregarBeneficio();
						break;
					case 3:
						lista_tarjetas.ImprimirTarjetas();
						Console.ReadKey();
						break;
						
					case 4:
						lista_tarjetas.ImprimirProm();
						Console.ReadKey();
						break;
						
					case 5:
						break;
						
					default:
						Console.WriteLine("Opcion incorrecta");
						break;
				}
				
				}while(op!=5);

			}
		
		public void ventas(){
			Cliente cliente; // defino una variable cliente de tipo Cliente
			try{
			Console.WriteLine("Ingrese DNI (sin puntos ni espacios)");
			string dni=Console.ReadLine(); // recibo el DNI y lo almaceno en una variable dni.
			bool cont= clientes.Comparar(dni); //llamo al método Comparar y analizo si es un cliente existente o no.
			if(cont==true){
				Console.WriteLine("Cliente existente");
				cliente = clientes.ClienteExistente(dni); //le asigno a la variable cliente, el dni del cliente existente
			}
			else{
				cliente = clientes.NuevoCliente(dni); //le asigno a la variable cliente, el dni del cliente nuevo
				}
			
			Console.WriteLine("Seleccione tarjeta para abonar: ");
			lista_tarjetas.ImprimirTarjetas(); //imprimo las tarjetas dadas de alta
			
			int n = int.Parse(Console.ReadLine()); //parseo el dato entrado por teclado
			
			Tarjeta tarjeta = lista_tarjetas.Obtener(n); //obtengo la tarjeta correspondiente del método obtener de la clase ListaTarjetas
			
			int[] cuotas = tarjeta.Cuotas; //le asigno al arreglo de enteros llamado cuotas, las cuotas de la tarjeta seleccionada
			int[] intereses = tarjeta.Intereses; //le asigno al arreglo de enteros llamado intereses, los intereses de la tarjeta seleccionada
			
			Console.WriteLine("Indique la cantidad de cuotas: ");
			int c = int.Parse(Console.ReadLine());
			
			double interes = 0;
			for(int i=1; i<=tarjeta.Cantidad_formas_pago;i++)
			{
				if(c==cuotas[i-1])
				{
					interes=intereses[i-1]; //selecciono la posición en que se encuentra dicho dato
				}
			}
			
			Console.WriteLine("En {0} cuotas tiene un interés de {1}%",c,interes);
			Console.WriteLine("En el carro hay un total de ${0}",carrito.Total);
			double precio_total = (carrito.Total*(1+(double)interes/100)); // defino precio_total, aplicandole el interés al total de compra
			
			double cu = precio_total/c; //defino el precio por cuota
			
			Console.WriteLine("Precio total financiado: ${0}, en {1} cuotas de ${2}",precio_total,c,cu);
			Console.WriteLine("¿Confirmar compra? (s/n)");
			
			string r = Console.ReadLine();
			
			if(r=="s")
			{
				cliente.TtlGastado += precio_total; //agrego el total gastado del cliente al precio total
				tarjeta.Total_compras += precio_total; //agrego el total de compras de cada tarjeta al precio_total 
				TotalTienda+=precio_total; //sumo las compras efectuadas a la variable TotalTienda, para saber el total vendido
				carrito = new Carro(); // creo una nueva instancia de carrito
				Console.WriteLine("¡Felicidades por su compra!, carro vacío");
			}
			if(r=="n")
				Console.WriteLine("\nCompra cancelada");
			}
		
			catch(FormatException){ //valido las excepciones por posibles errores y agrego una excepción generalizada
				Console.WriteLine("\nValor no válido");
			}
			catch(ArgumentOutOfRangeException){
				Console.WriteLine("\nOpción no válida, intente nuevamente");
			}
			catch(IndexOutOfRangeException){
				Console.WriteLine("\nOpción no válida, intente nuevamente");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
		}
		
		public void Administracion(){
			int op;
			do{ /* Implemento un Do While para que el menú se ejecute al menos una vez */
				Console.Clear();
				Console.WriteLine("*********************************************************************************************");
				Console.WriteLine("*************                       ADMINISTRACIÓN                              *************");
				Console.WriteLine("*********************************************************************************************\n");
				Console.WriteLine("¿Qué desea hacer?\n"); /* Muestro el menú */
				
				Console.WriteLine("1) Total vendido en la Tienda Online");
				Console.WriteLine("2) Total vendido por Cliente");
				Console.WriteLine("3) Total vendido por tarjeta");
				Console.WriteLine("4) Volver");
				
				op = int.Parse(Console.ReadLine()); /* Parseo el dato ingresado por el usuario para pasarlo 
				de string a entero */
				
				switch(op){ /* Inicializo el menu con un switch */
						
					case 1:
						Console.WriteLine("Total vendido en La Tienda Online es de: ${0}",TotalTienda);
						Console.ReadKey();
						break;
					case 2:
						clientes.TotalGastado();
						Console.ReadKey();
						break;
					case 3:
						lista_tarjetas.TotalTarjeta();
						Console.ReadKey();
						break;
					case 4:
						break;
					default:
						Console.WriteLine("Opcion incorrecta"); /* Agrego una opción más en caso de que se ingrese
						un numero fuera de rango */
						break;
				}
	
				}while(op!=4);
		}
			
	}
}