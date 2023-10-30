namespace VotacionConfench;

public class Universidad
{
    public string NombreUniversidad { get; set; }
    public int VotoAceptar {get;set;}
    public int VotoRechazar { get; set; }
    public int VotoNulo { get; set; }
    public int VotoBlanco { get; set; }

    public Universidad(string _nombreUniversidad,int _votoAceptar,int _votoRechazar,int _votoNulo,int _votoBlanco)
    {
        VotoAceptar = _votoAceptar;
        VotoRechazar = _votoRechazar;
        VotoNulo = _votoNulo;
        VotoBlanco = _votoBlanco;
        NombreUniversidad = _nombreUniversidad;
    }

    public  List<string> VerVotosUniversidad()
    {
        List<string> Votos = new List<string>();

        for(int i = 0; i < VotoAceptar; i++)
        {
            string A = "A";
            Votos.Add(A);
        }
        for(int i = 0; i < VotoRechazar; i++)
        {
            string A = "R";
            Votos.Add(A);
        }
        for(int i = 0; i < VotoNulo; i++)
        {
            string A = "N";
            Votos.Add(A);
        }
        for(int i = 0; i < VotoBlanco; i++)
        {
            string A = "B";
            Votos.Add(A);
        }
        Votos.Add("X");

        return Votos;
    }
    

}