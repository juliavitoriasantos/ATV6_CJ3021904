namespace ATV6_CJ3021904
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("Digite 0 para o exemplo= ");
            Console.WriteLine("Digite 1 para o exercício 1= ");
            Console.WriteLine("Digite 2 para o exercício 2= ");
            Console.WriteLine("Digite 3 para o exercício 3= ");
            Console.WriteLine("Digite 4 para o exercício 4= ");
            Console.WriteLine("Digite 5 para o exercício 5= ");
            Console.WriteLine("Digite 6 para o exercício 6= ");
            Console.WriteLine("Digite 7 para o exercício 7= ");

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {

                case 0:

                    Console.WriteLine("Sistema do Marquesito");

                    int a, temp;
                    int soma = 0;


                    for (a = 0; a < 3; a++)
                    {
                        Console.WriteLine("Digite um valor");

                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                            break;

                        soma = soma + temp;


                    }
                    Console.WriteLine("A média é {0}", soma / 3);

                    break;

                //Exercício 1

                case 1:

                    int n = 1, i;

                    Console.WriteLine("Digite um valor");
                    i = int.Parse(Console.ReadLine());

                    while (n < i)
                    {

                        Console.WriteLine(n);
                        n++;
                    }
                    break;

                //Exercício 2

                case 2:

                    int n1 = 1, i1;

                    Console.WriteLine("Digite um valor");
                    i1 = int.Parse(Console.ReadLine());

                   while (n1 < i1)
                    {

                        if (n1 % 2 == 0)
                        {

                            Console.WriteLine(n1);
                           
                        }
                        n1++;
                    }
                    break;

                case 3:

                    int d = 1000,c;

                    Console.WriteLine("Digite um valor menor que 1000");
                    c = int.Parse(Console.ReadLine());

                    while (d > c)
                    {

                        if (d % 2 == 0)
                        {

                            Console.WriteLine(d); 
                            d--;
                        }
                    }

                    break;

                    //Exercécio 4 


                case 4:


                    int k;
                    int s = 0;


                    while (s < 200)
                    {
                        Console.WriteLine("Digite um valor: ");
                        k = int.Parse(Console.ReadLine());

                        if (k > 0)
                        {
                            s = s + k;

                            Console.WriteLine("Soma = {0}", s);
                        }



                    }

                    break;

                case 5:

                    int div, a1 = 0;

                    Console.WriteLine("Digite um número inteiro: ");
                    div = int.Parse(Console.ReadLine());

                    while (a1 <= div)
                    {
                        if (div % a1 == 0)
                        {
                            Console.WriteLine(a1);
                            a1++;
                        }
                    }


                    break;


                case 6:


                    int j = 0, v;

                    while (j < 11)
                    {
                        Console.WriteLine("Digite um valor");
                        v = int.Parse(Console.ReadLine());
                        j++;

                        if (v < v)
                        {
                            Console.WriteLine("Número maior= {0}", v);
                        }
                        if (v > v)
                        {
                            Console.WriteLine("Número menor= {0}", v);
                        }


                    }

                    break;
                case 7:

                    int u;
                    int si = 0;
                    int sp = 0;

                    Console.WriteLine("Digite um valor: ");
                    u = int.Parse(Console.ReadLine());

                    while (u !=0)
                    {
                        Console.WriteLine("Digite um valor: ");

                        u = int.Parse(Console.ReadLine());
                        

                        if (u % 2 != 0)
                        {
                            si = si + u;
                        }
                        if (u % 2 == 0)
                        {
                            sp = sp + u;
                        }

                        Console.WriteLine("Soma dos números Ímpares= {0}, ", si, "Soma dos números Pares= {1} ", sp);
                    }



                    break;




            }
        }
    }
}
    

