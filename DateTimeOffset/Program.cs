using System;

namespace DateTimeOffsetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo DateTimeOffset!!");
            DateTimeOffset fecha = new DateTimeOffset(2017, 9, 10, 23, 50, 50, new TimeSpan(-1, 0, 0));
            DateTime fechaReferencia = new DateTime(2017, 9, 11);

            // Fecha en formato local del servidor
            var f1 = fecha.LocalDateTime;
            bool comparacion = f1 < fechaReferencia;
            Console.WriteLine($"Fecha del servidor: {f1.ToString("dd/MM/yyyy - H:mm:ss")}, Fecha Anterior: {comparacion}");

            // Fecha en formato UTC
            var f2 = fecha.UtcDateTime;
            comparacion = f2 < fechaReferencia;
            Console.WriteLine($"Fecha del servidor UTC: {f2.ToString("dd/MM/yyyy - H:mm:ss")}, Fecha Anterior: {comparacion}");

            // Fecha en formato de origen
            var f3 = fecha;
            comparacion = f3 < fechaReferencia;
            Console.WriteLine($"Fecha origen: {f3.ToString("dd/MM/yyyy - H:mm:ss")}, Fecha Anterior: {comparacion}");

            Console.ReadLine();
        }
        
    }
}
