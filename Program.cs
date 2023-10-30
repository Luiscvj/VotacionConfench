using VotacionConfench;

internal class Program
{
    private static void Main(string[] args)
    {   
        int UniversidadAcepta =0;
        int UniversidadRechaza =0;
        int UniversidadEmpate =0;
        
        List<Universidad> Universidades = new List<Universidad>();
        Console.WriteLine("Bienvenido al sistema de votacion CONFECH");
    
        Console.WriteLine("Por favor ingrese el numero de universidades a participar");
        int NumUniversidadesParticipantes = Convert.ToInt32(Console.ReadLine());

        while(NumUniversidadesParticipantes > 0)
        {
            Console.WriteLine($"Por favor ingrese el nombre de la universidad numero {NumUniversidadesParticipantes}");
            string _NombreUniversidad = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de Votos Aceptar");
            int _VotoAceptar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Votos Rechazar");
            int _VotoRechazar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Votos Nulo");
            int _VotoNulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Votos Blanco");
            int _VotoBlanco = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Universidad universidad = new Universidad
            (
                _NombreUniversidad,
                _VotoAceptar,
                _VotoRechazar,
                _VotoNulo,
                _VotoBlanco            
            );
            Universidades.Add(universidad);


            NumUniversidadesParticipantes -= 1;

            //Universidad Universidad = new Universidad
        }
        
        Console.WriteLine($"Numero de universidades participantes {Universidades.Count()}  HOLAAAAAAAS");
        foreach(Universidad u in Universidades)
        {

            Console.WriteLine($"Universidad {u.NombreUniversidad}");
            List<string> votosUniversidad = u.VerVotosUniversidad();

            foreach(string voto in votosUniversidad)
            {
                Console.WriteLine($"Voto: {voto}");

            }
        
            Console.WriteLine($"{u.NombreUniversidad}: {u.VotoAceptar} aceptan, {u.VotoRechazar} rechazan, {u.VotoBlanco} blancos, {u.VotoNulo} nulos ");
            
            if(u.VotoRechazar > u.VotoAceptar) UniversidadRechaza++;
            if(u.VotoAceptar > u.VotoRechazar) UniversidadAcepta++;
            if(u.VotoAceptar == u.VotoRechazar) UniversidadEmpate++;
            
        }

        Console.WriteLine($"Universidades que aceptan: {UniversidadAcepta}");
        Console.WriteLine($"Universidades que rechazan {UniversidadRechaza}");
        Console.WriteLine($"Universidades con empate: {UniversidadEmpate}");
        
        
 }
}