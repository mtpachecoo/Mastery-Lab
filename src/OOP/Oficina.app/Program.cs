var patio = new HashSet<Veiculo>();

patio.Add(new Veiculo("Civic", "ABC-1234"));
patio.Add(new Veiculo("Gol", "DEF-5678"));
patio.Add(new Veiculo("Civic", "ABC-1234")); // tentando adicionar veiculo duplicado



Console.WriteLine($"Veiculos no patio: {patio.Count}");

foreach (var veiculo in patio)
{
    Console.WriteLine($"Modelo: {veiculo.Modelo}, Placa: {veiculo.Placa}");
}
