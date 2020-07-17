using System;

namespace Integrador
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		private string tipo,marca,talle; /* Defino las variables como privadas */
		private double precio;
		private int descuento;
		private double cantidad;
		private double cantidad_precios;
		
		
		public Producto(string tipo,string marca, string talle,double precio) /* Modifico el constructor por defecto 
		añadiéndole parámetros */
		{
			this.tipo=tipo; /* Utilizo el this para indicarle al constructor las variables propias de la clase */
			this.marca=marca;
			this.talle=talle;
			this.precio=precio;
			cantidad=1; //inicializo la cantidad de productos en 1
		}
		
		public string Tipo{
			set{
				tipo=value; /* Utilizo las propiedades para poder acceder a las variables definidas como privadas */
			}
			get{
				return tipo;
			}
		}
		
		public string Marca{
			set{
				marca=value;
			}
			get{
				return marca;
			}
		}
		
		public string Talle{
			set{
				talle=value;
			}
			get{
				return talle;
			}
		}
		
		public double Precio{
			set{
				precio=value;
			}
			get{
				return precio;
			}
		}
		
		public int Descuento{
			set{
				descuento=value;
			}
			get{
				return descuento;
			}
		}
		
		public double Cantidad{
			set{
				cantidad=value;
			}
			get{
				return cantidad;
			}
		}
		
		public double Cantidad_precios{
			set{
				cantidad_precios=value;
			}
			get{
				return cantidad_precios;
			}
		}
	}
}
