using Cadastro_Pessoas.Interfaces;

/// <summary>
/// metodo de cadastro de pessoa fisica
/// </summary>
/// <returns></returns>
/// 


namespace Cadastro_Pessoas.Classes
{
    public abstract class Pessoa : InterfacePessoa
    {
        public string? Nome { get; set; }
        public float Rendimento { get; set; }
        public Endereco? endereco { get; set; }
        public abstract float PagarImpostos(float rendimento);

        public void VerificarPastaArquivo(string caminho)
        {

            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)) { }

            }
        }

    }
}