/*Faça um programa para ler dois vetores A e B, contendo N elementos cada. 
Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos elementos 
correspondentes de A e B. Imprima o vetor C gerado.*/

Console.WriteLine("Digite o tamanho de cada vetor");
int N = int.Parse(Console.ReadLine());

int[] VetA = new int[N];
int[] VetB = new int[N];

Console.WriteLine("Digite os elementos do vetor A");
for (int i = 0; i < N; i++)
{
    VetA[i] = int.Parse(Console.ReadLine());
    
}

Console.WriteLine("Digite os elementos do vetor B");
for (int i = 0; i < N; i++)
{
    VetB[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine("Soma dos elementos correspondentes:");
int[] VetC = new int[N];
for (int i = 0;i < N; i++)
{
    VetC[i] = VetA[i] + VetB[i];
    Console.WriteLine(VetC[i]);
}