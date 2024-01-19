Console.WriteLine("-----------(Maior e Menor Altura de 30 valores digitados)------------");
float[] ArmazenaAlturas = new float[30];
Console.WriteLine("Digite a altura da pessoa");
for (int Contador = 0; Contador <= 29; Contador++)

{
    Console.WriteLine($"Digite a {Contador + 1}ª altura");
    ArmazenaAlturas[Contador] = Convert.ToSingle(Console.ReadLine());
}
float MaiorAltura = ArmazenaAlturas.Max();
float MenorAltura = ArmazenaAlturas.Min();

Console.WriteLine("Maior altura é " + MaiorAltura);
Console.WriteLine("Menor altura é " + MenorAltura);
