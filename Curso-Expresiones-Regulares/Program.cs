// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
string caracter = "aaa";

 string patron= @"^a";

string patron2 = @"a$";

var regex= new Regex(patron);
var regex2 = new Regex(patron2);


if (regex.IsMatch(caracter)&& regex2.IsMatch(caracter))
{

    Console.WriteLine("Es Correcto");
}
else Console.WriteLine("es invalido");


string patron3 = @"\b me gusta\b";
var regex3= new Regex(patron3);

string texto2 = "buenas, soy Maximiliano y me gusta programar";



if (regex3.IsMatch(texto2))
{

    Console.WriteLine("Se encuentra en el texto");




}
else Console.WriteLine($"No se encuentra en el texto");