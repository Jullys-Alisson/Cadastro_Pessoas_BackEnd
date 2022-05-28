/// <summary>
/// metodo de cadastro de pessoa fisica
/// </summary>
/// <returns></returns>
/// 

namespace Cadastro_Pessoas.Classes
{
    public class Endereco
    {
        public string? logradouro { get; set; }
        public int casa { get; set; }
        public int numero { get; set; }
        public string? complemento { get; set; }
        public bool endComercial { get; set; }

    }
}