using System;
namespace Personas
{
	public class Persona
	{
		public Persona(string vNombre, int vNdia, int vNmes)
		{
			this.Nombre = vNombre;
			this.NDia = vNdia;
			this.NMes = vNmes;
		}
		private string nombre;
		private int ndia;
		private int nmes;
		public string Nombre
        {
			get
            {
				return nombre;
            }
			set 
			{
				nombre = value;
			}
        }
		public int NDia
		{
			get
			{
				return ndia;
			}
			set
			{
				ndia = value;
			}
		}
		public int NMes
		{
			get
			{
				return nmes;
			}
			set
			{
				nmes = value;
			}
		}
	}
}

