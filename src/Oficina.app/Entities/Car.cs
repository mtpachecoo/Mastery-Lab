public class Veiculo
{
    public string Modelo { get; set; }
    public string Placa { get; set; }

    public Veiculo(string modelo, string placa)
    {
        
        Modelo = modelo;
        Placa = placa;
    }
    public override bool Equals(object obj)
    {
        if(obj is not Veiculo other)
            return false;
        
        return Placa == other.Placa;
    }

    public override int GetHashCode()
    {
        return Placa.GetHashCode();
    }

}