using System;
using System.Collections;

namespace Tienda_virtual
{
	/// <summary>
	/// Description of ListaClientes.
	/// </summary>
	public class ListaClientes
	{
		private ArrayList clientes=new ArrayList();
			
		public ListaClientes()
		{
		}
		
		//Metodo para cliente existente. Recibe por parámetro un dni, lo busca, imprime sus datos y lo retora
		public Cliente ClienteExistente(string dni){
			Cliente cli = new Cliente(); // Creo una variable de tipo Cliente para almacenar al cliente encontrado
			foreach(Cliente c in clientes){ /* Utilizo un foreach para recorrer el ArrayList */
				if(dni==c.Dni){ // si dni coincide, imprimo los datos e igualo el cliente encontrado con la variable.
				Console.WriteLine("[Cliente Nombre={0},Apellido={1},DNI={2},Nacimiento={3},TtlGastado={4}]",c.Nombre,c.Apellido,c.Dni,c.Fechaden,c.TtlGastado);}
				cli = c;
			}
			return cli; // retorno cliente
		}
		
		public Cliente NuevoCliente(string dni){ //Método para nuevo cliente, recibe como parámetro dni
			Console.WriteLine("Ingrese su nombre: ");
			string nombre= Console.ReadLine();
			Console.WriteLine("Ingrese su apellido: ");
			string apellido= Console.ReadLine();
			Console.WriteLine("Ingrese su fecha de nacimiento (DD/MM/AA): ");
			string fechaden= Console.ReadLine();
			
			if(!string.IsNullOrWhiteSpace(nombre)&!string.IsNullOrWhiteSpace(apellido)&!string.IsNullOrWhiteSpace(dni)){
			Cliente cliente=new Cliente(nombre,apellido,fechaden,dni,0); //instancio un cliente recibiendo como parámetros los datos levantados por consola, dni 
			//y el total gastado por ese cliente nuevo inicializado en cero
			clientes.Add(cliente); //agrego el nuevo cliente al Arraylist clientes
			return cliente; //luego de agregar el nuevo cliente a la lista, lo retorno.
			}
			else
				Console.WriteLine("No se permiten caracteres invalidos.");
				Console.WriteLine("\n");
				return NuevoCliente(dni);
		}
		
		public bool Comparar(string dni){ //Recibo como parámetro el dni y comparo si es un cliente existente, si no lo es retorna false
			
			foreach(Cliente c in clientes)
			{
				if(c.Dni==dni)
					return true;
			}
			
			return false;
			
		}
		
		public void TotalGastado(){
			int i=1;
			foreach(Cliente c in clientes){ 
				if(c.TtlGastado>0){ //si el cliente efectuó la compra, imprimo en pantalla sus datos
				Console.WriteLine("{0}) [Cliente Nombre={1},Apellido={2},DNI={3},Nacimiento={4},TtlGastado=${5}]",i,c.Nombre,c.Apellido,c.Dni,c.Fechaden,c.TtlGastado);
				i++;
				}
			}
		}
	}
}
