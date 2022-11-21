internal class Program
{
    private static void Main(string[] args)
    {
        NumMayor N1 = new NumMayor (5,8);
        N1.MayorDeLosNumeros();

        NumeroPar N2 = new NumeroPar(50);
        N2.EsPar();

        Mayor N3 = new Mayor(10, 25, 60);
        N3.NumMayorDeLosTres();

        Indefinido N4 = new Indefinido(1,4,5,7,9,0);
        N4.imprimir();

        SumaDeNumeros N5 = new SumaDeNumeros(4, 5, 2, 7, 9, 1, 4, 4);
        N5.imprimir();

        SumaDeNumeros2 N6 = new SumaDeNumeros2(6, 6, 7, 3, 2, 7, 0);
        N6.imprimir();

        TipoDeTriangulo N7 = new TipoDeTriangulo(4, 7 , 4);
        N7.imprimir();

        MultiplosDe3 N8 = new MultiplosDe3(3);
        N8.Multiplo();

        MediaAritmetica N9 = new MediaAritmetica(3, 6, 8, 9, 5, 2, 0);
        N9.CalcularMediaAritmetica();

        Factor N10 = new Factor( 6 );
        N10.CalcularFactorial();
    }
}