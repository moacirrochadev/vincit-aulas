// Laço de Repetição ENQUANTO (condição) <while>

//Laço While
//Tabuada do 6
// int contador = 0;
// int tabuada = 6;
// int resultado;

// while(contador <= 10){
//     resultado = tabuada * contador;
//     Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
//     contador++;
// }
// Console.ReadKey(); // Mantém o console aberto

// int opcao = 0;
// String txtopcao;

// while (opcao != 5){
//     // Console.Clear();
//     Console.WriteLine("Sistema de Cadastro de Alunos VINCIT");
//     Console.WriteLine("====================================");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Editar cliente");
//     Console.WriteLine("3 - Remover cliente");
//     Console.WriteLine("4 - Listar clientes");
//     Console.WriteLine("5 - Sair");

//     Console.Write("Digite a opção desejada: ");
//     // opcao = int.Parse(Console.ReadLine());

//     txtopcao = Console.ReadLine();
//     if (int.TryParse(txtopcao, out opcao) == false) {
//         Console.WriteLine("Mermão, presta atenção aí!");
//         Console.ReadKey();
//     }

//     Console.Clear();
// }

int opcao = 0;
String txtopcao;

while (opcao != 5){
    Console.WriteLine("Calculadora Infinita");
    Console.WriteLine("====================================");
    Console.WriteLine("1 - Multiplicar");
    Console.WriteLine("2 - Dividir");
    Console.WriteLine("3 - Adição");
    Console.WriteLine("4 - Subtração");
    Console.WriteLine("5 - Sair");

    Console.Write("Digite a opção desejada: ");

    txtopcao = Console.ReadLine();
    if (int.TryParse(txtopcao, out opcao) == false) {
        Console.WriteLine("Não aprendeu a fazer conta na escola, quer minha ajuda né?");
        Console.ReadKey();
    }

    float resultado = 0;

    if (opcao == 1){
        Console.WriteLine("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());
        resultado = num1 * num2;
        // Console.WriteLine("O resultado da multiplicação é: " + (num1 * num2));
        Console.WriteLine($"{num1} x {num2} = {resultado}");
        Console.ReadKey();
    }

    if (opcao == 2){
        Console.WriteLine("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());
        resultado = num1 / num2;
        // Console.WriteLine("O resultado da multiplicação é: " + (num1 / num2));
        Console.WriteLine($"{num1} / {num2} = {resultado}");
        Console.ReadKey();
    }

    if (opcao == 3){
        Console.WriteLine("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());
        resultado = num1 + num2;
        // Console.WriteLine("O resultado da multiplicação é: " + (num1 + num2));
        Console.WriteLine($"{num1} + {num2} = {resultado}");
        Console.ReadKey();
    }

    if (opcao == 4){
        Console.WriteLine("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());
        resultado = num1 - num2;
        // Console.WriteLine("O resultado da multiplicação é: " + (num1 - num2));
        Console.WriteLine($"{num1} - {num2} = {resultado}");
        Console.ReadKey();
    }
}