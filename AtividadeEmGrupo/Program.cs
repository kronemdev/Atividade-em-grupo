// Declaração de variáveis.
bool control = false;
decimal salario = 0.00m;
int menu = 0;
int qtdMeses = 0;

// Metódo para receber o valor de salário e verificar
// se o valor digitado é válido para retornar ao sistema
decimal ReceberSalario()
{
    Console.Write("Informe o salário: ");

    if (!decimal.TryParse(Console.ReadLine(), out decimal infSalario))
    {
        Console.Clear();
        Console.WriteLine("========================================================");
        Console.WriteLine("Por favor! Digite um número válido!");
        Console.WriteLine("========================================================");
        control = true;
        return infSalario;
    }
    else
    {
        return infSalario;
    }
    //decimal infSalario = decimal.Parse(Console.ReadLine());
    //return infSalario;
}
// Laço de repetição do programa
do
{
    //Console.Clear();
    Console.WriteLine("Bem vindo ao Sistema de Calculo Salarial");
    Console.WriteLine();
    Console.WriteLine("Menu de Opções");
    Console.WriteLine($"1 - Novo salário" +
                      $"\n2 - Férias" +
                      $"\n3 - Décimo terceiro" +
                      $"\n4 - Sair");

    Console.Write("Digite a opção desejada: ");

    if (!int.TryParse(Console.ReadLine(), out menu))
    {
        Console.Clear();
        Console.WriteLine("========================================================");
        Console.WriteLine("Por favor! Digite um número válido!");
        Console.WriteLine("========================================================");
        control = true;
    }
    else
    {
        switch (menu)
        {
            case 1:
                salario = ReceberSalario();

                if (salario >= 0.00m && salario <= 350.00m)
                {
                    salario += salario * 0.15m;
                }
                else if (salario > 350.00m && salario <= 600.00m)
                {
                    salario += salario * 0.10m;
                }
                else
                {
                    salario += salario * 0.05m;
                }

                // Saída de dados para o usuário
                Console.Clear();
                Console.WriteLine("========================================================");
                Console.WriteLine($"O novo salário é R$ {salario:F2}");
                Console.WriteLine($"Pressione Enter para retornar ao menu.");
                Console.WriteLine("========================================================");
                Console.ReadLine();
                Console.Clear();
                control = true;
                break;
            case 2:
                //Console.Write("Informe o salário: ");
                salario = ReceberSalario();

                salario += salario * 0.50m;

                Console.Clear();
                Console.WriteLine("========================================================");
                Console.WriteLine($"O valor das Férias é R$ {salario:F2}");
                Console.WriteLine($"Pressione Enter para retornar ao menu.");
                Console.WriteLine("========================================================");
                Console.ReadLine();
                Console.Clear();

                control = true;

                break;
            case 3:
                Console.Write("Informe a quantidade de meses trabalhados: ");
                qtdMeses = int.Parse(Console.ReadLine());

                if (qtdMeses < 1 || qtdMeses > 12)
                {
                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine("Informe a quantidade de meses entre 1 e 12.");
                    Console.WriteLine($"Pressione Enter para retornar ao menu.");
                    Console.WriteLine("========================================================");
                    Console.ReadLine();
                    Console.Clear();
                    //control = true;
                }
                else
                {
                    salario = ReceberSalario();
                    salario = (salario * qtdMeses)/12;

                    Console.Clear();
                    Console.WriteLine("========================================================");
                    Console.WriteLine($"O valor do seu décimo terceiro é: R$ {salario:F2}");
                    Console.WriteLine($"Pressione Enter para retornar ao menu.");
                    Console.WriteLine("========================================================");
                    Console.ReadLine();
                    Console.Clear();
                    // control = true;
                }
                control = true;
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("========================================================");
                Console.WriteLine("Obrigado por usar nosso sistema!\nAté Breve!");
                Console.WriteLine("========================================================");

                control = false;
                break;

            default:
                Console.Clear();
                Console.WriteLine("========================================================");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine($"Pressione Enter para retornar ao menu.");
                Console.WriteLine("========================================================");
                Console.ReadLine();
                Console.Clear();

                control = true;
                break;
        }
    }

} while (control);
