/* PizzeriaEx:
 *
 *
 *
 *
 *
 *
 *
 *
 */

using Microsoft.Extensions.DependencyInjection;

// using PizzeriaConsole;
using PizzeriaConsole.IoC;
using PizzeriaConsole.Handlers;

Console.WriteLine("Buongiorno... Welcome to the best Pizzeria in the whole world!");

Console.WriteLine("$$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$");

var start = Startup.CreateHostBuilder() ?? throw new Exception("Not Started.");
var host = start.Build() ?? throw new Exception("Host Not Found.");
var handler = host.Services.GetService<IHandler>() ?? throw new Exception("Handler not Found.");

// var ... = host.Services.GetService<...>() ?? throw new Exception("... not Found.");

handler.Handle();

Console.WriteLine("$$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$ $$$$");

Console.WriteLine("Arrivederci... Bye, see you soon!");