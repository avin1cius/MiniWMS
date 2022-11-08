internal class Produto
{
    internal Guid UUID;
    internal string Tipo;
    internal string Marca;
    internal string PesoKg;
    internal string DimensaoCxLxA;
    internal string CustoReais{ get; }
    internal string DetalhesAdicionais;
    
    internal Produto(){}
    internal Produto(string uuid, string tipo, string marca, string pesoKg, string dimensaoCxLxA, string custoReais, string detalhesAdicionais)
    {
        UUID = new Guid (uuid);
        Tipo = tipo;
        Marca = marca;
        PesoKg = pesoKg;
        DimensaoCxLxA = dimensaoCxLxA;        
        CustoReais = custoReais;
        DetalhesAdicionais = detalhesAdicionais;
    }

    internal string[] GetEspecificacoes()
    {
        return new string[] {Tipo, Marca, PesoKg, DimensaoCxLxA, CustoReais};
    }
}