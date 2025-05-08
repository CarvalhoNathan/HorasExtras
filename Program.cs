// Escreva uma função que calcule o salário de um funcionário a partir salário-hora base, o total de horas trabalhadas e número de horas-extras executadas. 
// Considere que cada hora-extra é paga com acréscimo de 40%.

Console.Clear();

Console.WriteLine("Cálculo de salário-hora com horas extras");
Console.WriteLine();
Console.Write("Digite seu salário-hora: ");
double salario = double.Parse(Console.ReadLine()!);

Console.Write("Digite o total de horas trabalhadas: ");
double horasTrabalhadas = double.Parse(Console.ReadLine()!);

Console.Write("Digite o total de horas extras feitas: ");
double horasExtras = double.Parse(Console.ReadLine()!);

double pagamentoExtras = (salario * 0.4) * horasExtras;
double pagamentoNormal = salario * horasTrabalhadas;
double salarioTotal = pagamentoNormal + pagamentoExtras;

Console.WriteLine();
Console.WriteLine($"Salário total: {salarioTotal:F1}");
Console.WriteLine($"Pago nas horas extras: {pagamentoExtras:F1}");