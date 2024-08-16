public class PiramideAsteriscos
{
    public void piramideNormal(int max)
    {
        string piramide = "";
        for (int i = 0; i < max; i++)
        {
            piramide += "*";
            Console.WriteLine(piramide);
        }
        Console.ReadKey();
    }

    public void piramideReversa(int max)
    {
        string piramide = "";
        for (int i = 0; i < max; i++)
        {
            piramide += "*";
        }

        for (int i = max; i >= 1; i--)
        {
            Console.WriteLine(piramide.Remove(i));
            
        }
        Console.ReadKey();
    }

    public static void Main()
    {
        int max;
        Console.Write("Informe o tamanho máximo pirâmide: ");
        max = int.Parse(Console.ReadLine());
        PiramideAsteriscos piramide = new PiramideAsteriscos();
        piramide.piramideNormal(max);
        piramide.piramideReversa(max);

    }
}