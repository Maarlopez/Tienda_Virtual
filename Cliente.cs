using System;
using System.Collections;

namespace Tienda_virtual
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		private string nombre,apellido,fechaden,dni;
		private double ttlGastado;
		
		public Cliente()
		{
		}
		
		//ingreso las propiedades para que otras clases accedan desde afuera a las variables de tipo privadas
		
		public Cliente(string nombre, string apellido, string fechaden, string dni,double ttlGastado)
		{
			this.nombre=nombre;
			this.apellido=apellido;
			this.fechaden=fechaden;
			this.dni=dni;
			this.TtlGastado=ttlGastado;
		}
		
		public string Dni{
			set{
				dni=value;
			}
			get{
				return dni;
			}
		}
		
		public string Nombre{
			set{
				nombre=value;
			}
			get{
				return nombre;
			}
		}
		
		public string Apellido{
			set{
				apellido=value;
			}
			get{
				return apellido;
			}
		}
		
		public string Fechaden{
			set{
				fechaden=value;
			}
			get{
				return fechaden;
			}
		}
		
		public double TtlGastado{
			set{
				ttlGastado=value;
			}
			get{
				return ttlGastado;
			}
		}
	}
}
