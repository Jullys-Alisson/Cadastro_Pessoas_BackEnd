/// <summary>
/// metodo de cadastro de pessoa fisica
/// </summary>
/// <returns></returns>
/// 

namespace Cadastro_Pessoas.Interfaces
{
    public interface InterfacePessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);
        bool ValidarDataNasc(string dataNasc);

    }
}