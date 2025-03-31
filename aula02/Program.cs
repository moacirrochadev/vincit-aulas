using System.Runtime.InteropServices;

Console.WriteLine("Bem-vindo ao nosso restaurante italiano!");
Console.WriteLine("Cardápio:");
Console.WriteLine("1 - Pizza de calabresa");
Console.WriteLine("2 - Pizza de Peperone");
Console.WriteLine("3 - 4 Queijos");
Console.WriteLine("4 - Pizza Portuguesa");

// Tomar uma decisão: Qual pizza escolher?
int opcao, entrega;
opcao = int.Parse(Console.ReadLine());

Console.ReadKey();

// Estrutura de decisão/condicional (if = SE)
if (opcao == 1) {
    Console.WriteLine("Deseja comer no restaurante ou entrega?");
    
    entrega = int.Parse(Console.ReadLine());
    
    if (entrega == 1){
        Console.WriteLine("Pizza de calabresa será entregue em 10 minutos!");
    } else {
        Console.WriteLine("A pizza está saindo para entrega!");
    }

} else if (opcao == 2) {
    Console.WriteLine("Deseja comer no restaurante ou entrega?");
} else if (opcao == 3) {
    Console.WriteLine("Deseja comer no restaurante ou entrega?");
} else if (opcao == 4) {
    Console.WriteLine("Deseja comer no restaurante ou entrega?");
} else {
    Console.WriteLine("Opção inválida!"); 
}
