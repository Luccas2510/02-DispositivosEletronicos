namespace _02_DispositivosEletronicos.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; } //get: obter set: dar novos valores setar novos valores
        public string Modelo { get; set;}
        public int AnoDeFabricacao { get; set;}
        //Método
        public abstract string ExibirDetalhes();
    }
}
