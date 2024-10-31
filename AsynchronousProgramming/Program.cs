

//La programación asincrónica en C# te permite ejecutar tareas de manera no bloqueante, 
//lo cual es útil para mejorar el rendimiento y la capacidad de respuesta de las 
//aplicaciones, especialmente cuando se trabaja con operaciones que pueden tomar 
//tiempo, como el acceso a bases de datos, lectura/escritura de archivos, o llamadas 
//a servicios externos.

//En C#, la programación asincrónica se logra principalmente con los modificadores async y await. Aquí tienes una explicación de cómo funcionan y algunos ejemplos de código:

//1. Palabras clave async y await
//async: se utiliza para definir un método asincrónico. Esto permite que el método use 
//await dentro de su cuerpo.
//await: se utiliza para indicar que el programa debe esperar la finalización de una 
//operación asincrónica antes de continuar. Cuando se usa await, el flujo de ejecución 
//sale del método y permite que otras tareas continúen ejecutándose.


//Ejemplo básico de programación asincrónica:
//Este ejemplo simula una operación que tarda en completarse, como una llamada a una
//API externa:
Console.WriteLine("Iniciando tarea...");
await RealizarOperacionAsincrona();
Console.WriteLine("Tarea completada.");
static async Task RealizarOperacionAsincrona()
{
    Console.WriteLine("Comenzando operación...");
    await Task.Delay(3000);  // Simula una espera de 3 segundos
    Console.WriteLine("Operación completada.");
}


//Ejemplo con operaciones concurrentes:
//Este ejemplo realiza múltiples operaciones asincrónicas al mismo tiempo, 
//aprovechando Task.WhenAll para esperar a que todas terminen.
Console.WriteLine("Iniciando tareas concurrentes...");

Task tarea1 = OperacionAsincrona("Tarea 1", 2000);
Task tarea2 = OperacionAsincrona("Tarea 2", 3000);
Task tarea3 = OperacionAsincrona("Tarea 3", 1000);

await Task.WhenAll(tarea1, tarea2, tarea3);

Console.WriteLine("Todas las tareas completadas.");
    

    static async Task OperacionAsincrona(string nombre, int delay)
{
    Console.WriteLine($"{nombre} comenzando...");
    await Task.Delay(delay);
    Console.WriteLine($"{nombre} completada después de {delay}ms.");
}