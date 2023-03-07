double[] priVetor = new double[5];
double[] segVetor = new double[5];
double[] finalVetor = new double[10];

priVetor = criarVetor("vetor A");

segVetor = criarVetor("vetor B");

finalVetor = inserirVetor(priVetor, segVetor);

Console.WriteLine("\nPrimeiro vetor é: ");
imprimeVetor(priVetor);
Console.WriteLine("\nSegundo vetor é: ");
imprimeVetor(segVetor);

Console.WriteLine("\nTerceiro vetor é: ");
imprimeVetor(finalVetor);

ordenaVetor(finalVetor);
Console.WriteLine("\nTerceiro vetor ordenado é: ");
imprimeVetor(finalVetor);

void ordenaVetor(double[] vetor)
{
    double aux = 0;

    for (int i = 0; i < (vetor.Length - 1); i++)
    {
        for (int j = i + 1; j < (vetor.Length); j++)
        {
            if (vetor[i] > vetor[j])
            {
                aux = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = aux;
            }
        }
    }
}

double[] inserirVetor(double[] insereA, double[] insereB)
{
    double[] aux = new double[10];
    for (int i = 0; i < insereA.Length; i++)
        aux[i] = insereA[i];
    for (int i = 0; i < insereB.Length; i++)
        aux[i + 5] = insereB[i];
    return aux;
}

void imprimeVetor(double[] printVetor)
{
    for (int i = 0; i < printVetor.Length; i++)
    {
        Console.Write(printVetor[i] + " ");
    }
    Console.WriteLine();
}

double[] criarVetor(string nome)
{
    double[] Vetor = new double[5];

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Insira o " + (i + 1) + "º número do " + nome + ":");
        if (!double.TryParse(Console.ReadLine(), out Vetor[i]))
        {
            Console.WriteLine("Por favor digite um número válido!\n");
            i--;
        }

    }

    return Vetor;
}