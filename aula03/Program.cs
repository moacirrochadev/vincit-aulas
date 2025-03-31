// Usando o ASCII Art Generator
// http://patorjk.com/software/taag/#p=display&f=Big&t=Corinthians

// Console.WriteLine(@"  /$$$$$$                      /$$             /$$     /$$       /$$                              ");
// Console.WriteLine(@" /$$__  $$                    |__/            | $$    | $$      |__/                              ");
// Console.WriteLine(@"| $$  \__/  /$$$$$$   /$$$$$$  /$$ /$$$$$$$  /$$$$$$  | $$$$$$$  /$$  /$$$$$$  /$$$$$$$   /$$$$$$$");
// Console.WriteLine(@"| $$       /$$__  $$ /$$__  $$| $$| $$__  $$|_  $$_/  | $$__  $$| $$ |____  $$| $$__  $$ /$$_____/");
// Console.WriteLine(@"| $$      | $$  \ $$| $$  \__/| $$| $$  \ $$  | $$    | $$  \ $$| $$  /$$$$$$$| $$  \ $$|  $$$$$$ ");
// Console.WriteLine(@"| $$    $$| $$  | $$| $$      | $$| $$  | $$  | $$ /$$| $$  | $$| $$ /$$__  $$| $$  | $$ \____  $$");
// Console.WriteLine(@"|  $$$$$$/|  $$$$$$/| $$      | $$| $$  | $$  |  $$$$/| $$  | $$| $$|  $$$$$$$| $$  | $$ /$$$$$$$/");
// Console.WriteLine(@"\______/  \______/ |__/      |__/|__/  |__/   \___/  |__/  |__/|__/ \_______/|__/  |__/|_______/  ");
// Console.ReadKey(); // Mantém o console aberto

// Conteúdo da Aula do dia 17/03/2025
/*Variáveis: 4 Tipos

Desvios Condicionais: SE...SENÃO/if...else

Laços de Repetição: FOR/WHILE/DO...WHILE
*/
//PARA...ATÉ...FAÇA
// int contador;
// for(contador = 1; contador <= 12; contador++){
//     Console.WriteLine("Contador: " + contador);
// }

// Console.ReadKey(); // Mantém o console aberto

//Laço For
// Tabuada do 8
// int contador;
// int tabuada = 7;
// int resultado;

// for(contador = 1; contador <= 10; contador++){
//     resultado = tabuada * contador;
//     Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
// }
// Console.ReadKey(); // Mantém o console aberto

// Fazer a Tabuada do 1 ao 9
// Fazer a Tabuada do 1 ao 9 de 1 a 10

Console.WriteLine("Tabuada do 1 ao 10");

int contador;
int tabuada;
int resultado;

for(tabuada = 1; tabuada <= 10; tabuada++){
    Console.WriteLine("Tabuada do " + tabuada);
    for(contador = 1; contador <= 10; contador++){
        resultado = tabuada * contador;
        Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
    }
    Console.WriteLine();
}
Console.ReadKey(); // Mantém o console aberto