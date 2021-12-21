using System;
using System.Collections;

namespace Tienda_virtual
{
	/// <summary>
	/// Description of Carro.
	/// </summary>
	public class Carro
	{
		ArrayList carrito=new ArrayList(); // creo un Arraylist llamado carrito y lo instancio
		double total=0; // defino una variable llamada total inicializada en 0
		
		public Carro()
		{
		}
		
		public void Agregar(ListaProductos lista){ //Recibe una lista de productos como parametro
			//En este método se va sumando el total del carro
			int a;
			double b;
			Console.WriteLine("Seleccione un producto para agregar al carro:");
			lista.Imprimir(); // llamo al método Imprimir de ListaProductos
		
			a=int.Parse(Console.ReadLine()); // Parseo la entrada por teclado
			
			Console.WriteLine("Ingrese cantidad de productos:");
			
			b=double.Parse(Console.ReadLine());
			
			Producto p = lista.Obtener(a); // llamo al método Obtener, para levantar el producto seleccionado. Selecciona el valor ingresado 
			//por el usuario en la posición n-1
			
			p.Cantidad=b;
			
			p.Cantidad_precios=p.Cantidad*p.Precio;
			total+=p.Cantidad_precios; // le sumo a total el precio del producto seleccionado por la cantidad de producto
			carrito.Add(p); //agrego el producto al Arraylist carrito
		}
		
		public void ListaCarrito(){
			int i=1;
			
			foreach(Producto p in carrito){ /* Utilizo un foreach para recorrer el ArrayList */
				Console.WriteLine("{5}) Cantidad:{6} [Producto tipo={0},marca={1},talle={2},precio={3},descuento={4}%]",p.Tipo,p.Marca,p.Talle,p.Precio,p.Descuento,i,p.Cantidad);
				i++;
			}
			Console.WriteLine("Total de compra: ${0}",total);
		}
		
		public void Quitar(){ //En este método se va quitando productos del carro
			int b;
			Console.WriteLine("Seleccione un producto para quitar del carro:");
			
			ListaCarrito(); //llamo al método ListaCarrito de la clase
			
			b=int.Parse(Console.ReadLine());
			Producto p = (Producto)carrito[b-1]; //le asigno a p de tipo Producto, la posición del producto seleccionado
			
			
			total -= p.Cantidad_precios; //le resto el precio al total
			carrito.RemoveAt(b-1); //remuevo el producto del ArrayList carrito
		}
		
		public double Total{
			set{
				total=value; /* Utilizo las propiedades para poder acceder a las variables definidas como privadas */
			}
			get{
				return total;
			}
		}
	}
}
