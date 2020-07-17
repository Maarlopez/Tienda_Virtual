using System;

namespace Integrador
{
	/// <summary>
	/// Description of Tarjeta.
	/// </summary>
	public class Tarjeta
	{
		private string nombre, banco;
		private int [] cuotas,intereses;
		private int cantidad_formas_pago;
		private double total_compras;
		private int [] intereses_anteriores = new int[0];
		
		
		public Tarjeta(string nombre,string banco, int [] cuotas, int [] intereses, int cantidad_formas_pago, double total_compras)
		{
			this.nombre=nombre;
			this.banco=banco;
			this.cuotas=cuotas;
			this.intereses=intereses;
			this.cantidad_formas_pago=cantidad_formas_pago;
			this.total_compras=total_compras;
		}
		
		public void Imprimir(){
			for(int i=1;i<=cantidad_formas_pago;i++){
				Console.WriteLine("\t\t{0} cuotas con {1}% interés",cuotas[i-1],intereses[i-1]);
			}
		}
		
		public void GuardarInteres(){
			intereses_anteriores = new int[cantidad_formas_pago];
			for(int i = 0 ; i<cantidad_formas_pago;i++)
			{
				intereses_anteriores[i]=intereses[i];
			}
		}
		
		public string Nombre{
			set{
				nombre = value; /* Utilizo las propiedades para poder acceder a las variables definidas como privadas */
			}
			get{
				return nombre;
			}
		}
		
		public string Banco{
			set{
				banco=value;
			}
			get{
				return banco;
			}
		}
		
		public int [] Cuotas{
			set{
				cuotas=value;
			}
			get{
				return cuotas;
			}
		}
		
		public int [] Intereses{
			set{
				intereses=value;
			}
			get{
				return intereses;
			}
		}
		
		public int Cantidad_formas_pago{
			set{
				cantidad_formas_pago=value;
			}
			get{
				return cantidad_formas_pago;
			}
		}
		
		public double Total_compras{
			set{
				total_compras=value;
			}
			get{
				return total_compras;
			}
		}
		
		public int[] Intereses_anteriores{
			set{
				intereses_anteriores = value;
			}
			get{
				return intereses_anteriores;
				
			}
		}
		
		public bool tieneBeneficio(){
			
			bool b = false;
			
													//si no es null recorre y comprueba
			for(int i = 1; i<=intereses_anteriores.Length;i++){
			int actual = intereses[i-1];
			int anterior = intereses_anteriores[i-1];
			if(actual<anterior)
				b = true;
			}
													
													
			return b;
			}
		
		}
	}
