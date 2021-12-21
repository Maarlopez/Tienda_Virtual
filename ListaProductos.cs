using System;
using System.Collections;

namespace Tienda_virtual
{
	/// <summary>
	/// Description of ListaProductos.
	/// </summary>
	public class ListaProductos
	{
		ArrayList Productos=new ArrayList(); /* Creo una nueva instancia de tipo Arraylist para almacenar
		los distintos productos */
		
		
		public ListaProductos() /* Constructor por defecto */
		{
		}
		
		public void Agregar(){ /* Creo un nuevo método para agregar productos al Array */
			
			try{
			Console.WriteLine("Ingrese tipo de producto");
			string tipo=Console.ReadLine();
			Console.WriteLine("Ingrese marca de producto");
			string marca=Console.ReadLine();
			Console.WriteLine("Ingrese talle de producto");
			string talle=Console.ReadLine();
			Console.WriteLine("Ingrese precio de producto");
			double precio=double.Parse(Console.ReadLine());
			
			Producto p= new Producto(tipo,marca,talle,precio); //instancio un nuevo producto
			
			Productos.Add(p); /* Agrego producto al Arraylist */
			}
			
			catch(FormatException){
				Console.WriteLine("\nIngrese un valor correcto");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
		}
		
		public void Imprimir(){ /* Creo un metodo Imprimir para mostrar en pantalla los productos */
			int i=1;
			
			foreach(Producto p in Productos){ /* Utilizo un foreach para recorrer el ArrayList */
				Console.WriteLine("\n{5}) [Producto tipo={0},marca={1},talle={2},precio={3},descuento={4}%]",p.Tipo,p.Marca,p.Talle,p.Precio,p.Descuento,i);
				i++;
				
			}
			
		}
		
		public void AgregarDescuento(){ /* Creo un metodo para agregar descuento a determinados productos */
			
			Console.WriteLine("Seleccione un producto para la promo:");
			Imprimir();
			
			try{
			
			int p=int.Parse(Console.ReadLine());
				
			Producto producto_aux=(Producto)Productos[p-1]; //selecciono el producto indicado por el usuario 
			
			Console.WriteLine("Indique porcentaje de descuento: ");
			int d=int.Parse(Console.ReadLine());
			
			producto_aux.Descuento=d; //le asigno el nuevo descuento al producto
			
			}
			catch(ArgumentOutOfRangeException){
				Console.WriteLine("\nNo existe ese producto");
			}
			catch(Exception){
				Console.WriteLine("Ha ocurrido un error.");
			}
		}
		
		public void ImprimirProm(){
			int i=1;
			foreach(Producto p in Productos){ /* Utilizo un foreach para recorrer el ArrayList */
				if(p.Descuento!=0)
					Console.WriteLine("{5}) [Producto tipo={0},marca={1},talle={2},precio={3},descuento={4}%]",p.Tipo,p.Marca,p.Talle,p.Precio,p.Descuento,i);
					i++;				
			}
		}
		
		public Producto Obtener(int n){
			return (Producto)Productos[n-1];
		}
	}
}
