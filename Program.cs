using System.Diagnostics;

namespace StopwatchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exemplo de uso da classe Stopwatch, quanto tempo para fazer um laço de 1 a 1.0000.000.000 
            // Example of using the Stopwatch class, how long to make a loop from 1 to 1,0000,000,000


            // Criar uma instância da classe Stopwatch
            // Create an instance of the Stopwatch class
            Stopwatch myStopwatch = new();

            // Iniciar a contagem de tempo
            // Start counting time
            myStopwatch.Start();

            // Laço de 1 a 1.000.000.000 simulando um processamento
            // Loop from 1 to 1,000,000,000 simulating a processing
            int cont = 1;
            for (int i = 1; i <= 1000000000; i++) {
                cont++;
            }

            // Parar a contagem de tempo
            // Stop counting time
            myStopwatch.Stop();

            // Pegar o tempo decorrido
            // Get the elapsed time
            TimeSpan myTimeElapsed = myStopwatch.Elapsed;

            // Formatar o texto para exibição
            // Format text for display
            string mytTimeElapsedFormated = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            myTimeElapsed.Hours, myTimeElapsed.Minutes, myTimeElapsed.Seconds,
                                            myTimeElapsed.Milliseconds / 10);

            // Mostrar tempo decorrido
            // Show elapsed time
            Console.WriteLine("Tempo decorrido/Elapsed time:" + mytTimeElapsedFormated);
        }
    }
}
