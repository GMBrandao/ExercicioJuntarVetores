double[] priVetor = new double[5];
double[] segVetor = new double[5];
double[] finalVetor = new double[10];
int count = 0;

priVetor = criarVetor("vetor A");

segVetor = criarVetor("vetor B");

Console.WriteLine("\nPrimeiro vetor é: ");
imprimeVetor(priVetor);
Console.WriteLine("\nSegundo vetor é: ");
imprimeVetor(segVetor);

inserirVetor(priVetor);
inserirVetor(segVetor);

Console.WriteLine("\nTerceiro vetor é: ");
imprimeVetor(finalVetor);

double[] inserirVetor(double[] insereVetor) 
{
    for(int i = 0; i < insereVetor.Length; i++)
    {
        finalVetor[count] = insereVetor[i];
        count++;
    }
    return insereVetor;
}

void imprimeVetor(double[] printVetor)
{
    for(int i = 0; i < printVetor.Length; i++)
    {
        Console.Write(printVetor[i]+ " ");
    }
    Console.WriteLine();
}

double[] criarVetor(string nome)
{
    double[] Vetor = new double[5];

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Insira o " + (i + 1) + "º número do " + nome + ":");
        Vetor[i]  = double.Parse(Console.ReadLine());
    }

    return Vetor;
}