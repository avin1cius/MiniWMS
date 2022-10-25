public class Produto
{
    internal string Marca;
    internal string PesoKg;
    internal string CustoReais;
    internal string DimensaoCxLxA;
    
    public Produto(string marca, string pesoKg, string custoReais, string dimensaoCxLxA)
    {
        Marca = marca;
        PesoKg = pesoKg;
        CustoReais = custoReais;
        DimensaoCxLxA = dimensaoCxLxA;
    }

    public string[] GetEspecificacoes()
    {
        return new string[] {Marca, PesoKg, CustoReais, DimensaoCxLxA};
    }
}

public class Televisao : Produto
{
    string Polegadas;
    string Resolucao;

    public Televisao(Produto produto, string polegadas, string resolucao)
    {
        Produto();
        Marca = produto.Marca;
        PesoKg = produto.PesoKg;
        CustoReais = produto.CustoReais;
        DimensaoCxLxA = produto.DimensaoCxLxA;
        Polegadas = polegadas;
        Resolucao = resolucao;


    }

}

public class Smartphone : Produto
{
    string Polegadas;
    string Resolucao;
    string MemoriaGB;
    string ArmazenamentoGB;

    public Smartphone(Produto produto, string polegadas, string resolucao)
    {
        Marca = produto.Marca;

    }
}

public class Laptop : Produto
{

}