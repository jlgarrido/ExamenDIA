using System;
using System.Diagnostics;

namespace ProgramacionContrato
{
	class MainClass
	{
		public static int Divide(int a, int b){
			Debug.Assert (b != 0, "El divisor es 0");
			return a / b;
		}

		public static void Main (string[] args)
		{
			try{
			Console.WriteLine ("Introduce un numero: ");
			int a = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Introduce otro numero: ");
			int b = Convert.ToInt32 (Console.ReadLine ());
				 int dos = Divide(a,b);
				Console.WriteLine("El resultado de la division es {0}", dos);
			}catch(DivideByZeroException e){
				Console.WriteLine ("El divisor no puede ser 0", e);
			}
		
		}
	}
}
