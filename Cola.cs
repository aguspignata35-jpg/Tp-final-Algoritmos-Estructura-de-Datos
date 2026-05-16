
using System;
using System.Collections.Generic;

namespace tp1
{
	public class Cola<T>
	{

		
		private List<T> datos = new List<T>();
		
		public void encolar(T elem)
		{
			this.datos.Add(elem);
		}
		
		public T desencolar()
		{
			if (esVacia())
			throw new InvalidOperationException("No se puede , la cola se encuentra vacia");
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
		
		public T tope()
		{
			if(esvacia())
			throw new InvalidOperationException("No se puede ver el tope la cola se encuentra vacia");
			return this.datos[0];
		}
		
		public bool esVacia()
		{
			return this.datos.Count == 0;
		}
		
		public int cantidadElementos()
		{
			return this.datos.Count;
		}
		public void limpiar()
		{
			this.dato.Clear();
		}
		public bool contiene (T elem)
		{
			return this.datos.Contains(elem);
		}
	}
}
