namespace Laboratorio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo("Equipo1", 3, 0, 0, 1, 0);
            Equipo equipo2 = new Equipo("Equipo2", 1, 1, 1, 1, 1);

            Console.WriteLine(equipo1.GetNombre() + "_" + equipo1.GetPartidosGanados() + "_" +
                equipo1.GetPartidosPerdidos() + "_" + equipo1.GetPartidosEmpatados() + "_" +
                equipo1.GetGolesFavor() + "_" + equipo1.GetGolesContra());
            Console.WriteLine(equipo2.GetNombre() + "_" + equipo2.GetPartidosGanados() + "_" +
                equipo2.GetPartidosPerdidos() + "_" + equipo2.GetPartidosEmpatados() + "_" +
                equipo2.GetGolesFavor() + "_" + equipo2.GetGolesContra());

        }
    }
}