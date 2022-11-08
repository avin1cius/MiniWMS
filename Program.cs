using System;

const string TelevisaoSamsung = "174bc7d3-203f-48e3-a387-34ab59c1d0ae";
const string TelevisaoLG = "1f982770-908a-429c-bf48-0952e6e19e06";
const string SmartphoneApple = "4d7ba2cc-6313-49c9-bb38-9aed6876bbd8";
const string SmartphoneSamsung = "3766b5fa-8177-4a7b-811f-cbae05fd9d11";
const string LaptopApple = "79205ed0-9eca-4353-aef7-6599273e17f0";
const string LaptopSamsung = "423d2da7-2ed3-4050-8785-2c5b51b53fb2";
const string Microonda = "5652e4fe-f548-449f-b22c-3621e08a9a11";
const string Geladeira = "b1eaa886-abbf-495f-be95-51ae6fca602c";
const string MaquinadeLavar = "5edd1429-bbff-4edd-a7fa-9098c01498b2";
const string CondicionadordeAr = "e13f051d-47c7-41dc-a5d3-4fbc609c5734";

Console.Clear();
Produto[] televisao = new Produto[]{
    new Produto(TelevisaoSamsung,"TV","Samsung","5","50x50x50","3000", "50 polegadas e resolução 4K"),
    new Produto(TelevisaoLG,"TV","LG","4,8","50x50x50","3000", "48 polegadas e resolução 4K"),
    new Produto(SmartphoneApple,"Smartphone","Apple","1","10x10x10","4300", "128 GB de armazenamento"),
    new Produto(SmartphoneSamsung,"Smartphone","Samsung","1","10x10x10","3900", "128 GB de armazenamento"),
    };

var especificacoes = televisao[1].GetEspecificacoes();
Console.WriteLine(
    $"Tipo: {especificacoes[0]}\nMarca: {especificacoes[1]}"
    );

Console.WriteLine(televisao[0].QuantidadeEmEstoque);
televisao[0].SetQuantidadeEmEstoque(10);
Console.WriteLine(televisao[0].QuantidadeEmEstoque);
Console.ReadLine();