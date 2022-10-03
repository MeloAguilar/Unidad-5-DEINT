namespace Entities
{
	public class clsPersona
	{
		#region Atributos
		private String nombre;
		private String apellidos;
		#endregion

		#region Propiedades
		public String Nombre
		{
			get => nombre;
			set { if (String.IsNullOrEmpty(value)) { this.nombre = value; } }

		}

		public String Apellidos
		{
			get =>	apellidos;
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					apellidos = value;
				}
			}
		}
		#endregion

		#region Constructores
		public clsPersona(String _nombre, String _apelidos)
		{
			this.nombre = _nombre;
			this.apellidos = _apelidos;
		}

		public clsPersona(String _nombre) 
		{
			this.nombre = _nombre;
		}

		public clsPersona()
		{
			this.nombre = "";
		}
		#endregion
	}
}