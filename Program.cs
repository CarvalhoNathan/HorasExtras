// Escreva uma função que calcule o salário de um funcionário a partir salário-hora base, o total de horas trabalhadas e número de horas-extras executadas. 
// Considere que cada hora-extra é paga com acréscimo de 40%.

Console.Clear();

decimal salarioHoraBase, salario;
int horasTrabalhadas, numeroHorasExtras;

Console.WriteLine("Cálculo de salário-hora com horas extras");
Console.WriteLine();

// Solicitar os dados do usuário
Console.Write("Digite seu salário-hora: ");
salarioHoraBase = decimal.Parse(Console.ReadLine()!);

Console.Write("Digite o total de horas trabalhadas: ");
horasTrabalhadas = int.Parse(Console.ReadLine()!);

Console.Write("Digite o total de horas extras feitas: ");
numeroHorasExtras = int.Parse(Console.ReadLine()!);

 // Executar função CalculaSalario
salario = CalculaSalario(salarioHoraBase, horasTrabalhadas, numeroHorasExtras);

// Função que calcula o salário total
decimal CalculaSalario(decimal salarioHoraBase, int horasTrabalhadas, int numeroHorasExtras)
{
    decimal salarioTotal;

    if (numeroHorasExtras > 0)
    {
        decimal valorHoraExtra = salarioHoraBase * 1.4m;
        salarioTotal = (salarioHoraBase * horasTrabalhadas) + (valorHoraExtra * numeroHorasExtras);
    }
    else
    {
        salarioTotal = salarioHoraBase * horasTrabalhadas;
    }
    return salarioTotal;
}

// Exibir os resultados
Console.WriteLine();
Console.WriteLine($"Salário total: {salario:C2}");
Console.WriteLine($"Pago nas horas extras: {(numeroHorasExtras > 0 ? (salarioHoraBase * 1.4m * numeroHorasExtras).ToString("C2") : "0.0")}");