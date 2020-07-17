using System;
using System.Collections;

namespace Integrador
{
	/// <summary>
	/// Description of ListaTarjetas.
	/// </summary>
	public class ListaTarjetas
	{
		private ArrayList tarjetas=new ArrayList();
		
		public ListaTarjetas()
		{
		}
		
		public void AgregarTarjeta(){
			try{
				Console.WriteLine("Ingrese tarjeta");
			
			string tarjeta=Console.ReadLine();
			Console.WriteLine("Ingrese banco");
			string banco=Console.ReadLine();
			Console.WriteLine("Ingrese cantidad de formas de pago");
			int cantidad_formas_pago=int.Parse(Console.ReadLine());
			
			int [] cuotas= new int[cantidad_formas_pago]; //instancio e inicializo los arreglos de enteros cuotas e intereses
			int [] intereses=new int[cantidad_formas_pago];

			if(cantidad_formas_pago>0){
				for(int i=1;i<=cantidad_formas_pago;i++)
				{
				Console.WriteLine("Forma de pago #{0}",i);
				Console.WriteLine("Ingrese número de cuotas: ");
				cuotas[i-1]=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese interes por cuota: ");
				intereses[i-1]=int.Parse(Console.ReadLine());
				
				}
			
				Tarjeta t= new Tarjeta(tarjeta,banco,cuotas,intereses,cantidad_formas_pago,0); //instancio una nueva tarjeta
			
				tarjetas.Add(t); //agrego la nueva tarjeta al arraylist tarjetas
				}
			else
				Console.WriteLine("La cantidad de formas de pago no puede ser: {0}",cantidad_formas_pago);
				Console.ReadKey();
			
			}
			
			catch(FormatException){
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
		
		public void ImprimirTarjetas(){
			int i=1;
			foreach(Tarjeta t in tarjetas){
				Console.WriteLine("{0}) [Tarjeta nombre={1}, Banco={2}, Cantidad formas de pago={3}, Total compras={4}]",i,t.Nombre,t.Banco,t.Cantidad_formas_pago,t.Total_compras);
				t.Imprimir();
				i++;
				
						
				
			}
		}
		
		public void AgregarBeneficio(){
			try{
			Console.WriteLine("Seleccione una tarjeta para el beneficio: ");
			
			ImprimirTarjetas();
			int a=int.Parse(Console.ReadLine());
			
			Tarjeta t=Obtener(a);
			
			t.GuardarInteres(); // guardo los intereses antes de modificar
			
			Console.WriteLine("Ingrese cantidad de cuotas: ");
			int c=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese interés por cuota: ");
			int i=int.Parse(Console.ReadLine());
			
			
			for(int x=1;x<=t.Cantidad_formas_pago;x++){//utilizo un for para agregar el beneficio
				if(t.Cuotas[x-1]==c){ 
					t.Intereses[x-1]=i;
				}		
			}
			}
			
			catch(FormatException){
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
		
		
		public void ImprimirProm(){
			int i=1;
			foreach(Tarjeta t in tarjetas){ /* Utilizo un foreach para recorrer el ArrayList */	
			
				
				if(t.tieneBeneficio() == true){
					
					Console.WriteLine("{0}) [Tarjeta nombre={1}, Banco={2}, Cantidad formas de pago={3}, Total compras={4}]",i,t.Nombre,t.Banco,t.Cantidad_formas_pago,t.Total_compras);
					t.Imprimir();
				}
			}
		}
		
		public Tarjeta Obtener(int n){
			return (Tarjeta)tarjetas[n-1];
		}
		
		public void TotalTarjeta(){ //método para obtener el total gastado con cada tarjeta
			int i=1;
			foreach(Tarjeta t in tarjetas){
				if(t.Total_compras>0){ //si el total es mayor a cero, imprimo la tarjeta
					Console.WriteLine("{0}) [Tarjeta nombre={1}, Banco={2}, Total compras=${3}]",i,t.Nombre,t.Banco,t.Total_compras);
					i++;
				}
			}
		}
	}
}