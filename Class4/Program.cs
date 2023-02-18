// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Class4.Entidad;
using Class4.Negocio;

EntidadContador Texto = new EntidadContador ();
ClsNegocioContador clsNegocioContador = new ClsNegocioContador();

static void Main (string[] args)
{
  Console.WriteLine("Ingrese un Texto:");
  string textoIngresado = Console.ReadLine();

  EntidadContador entidad = new EntidadContador();
  entidad.Texto = textoIngresado;

  ClsNegocioContador negocio = new ClsNegocioContador();
  int cantidadLetras = negocio.ContarLetras(entidad);

  Console.WriteLine ("La cantidad de letras que  ingreso son: " + cantidadLetras);
}