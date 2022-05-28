using System.Text.RegularExpressions;
using Cadastro_Pessoas.Interfaces;

/// <summary>
/// metodo de cadastro de pessoa fisica
/// </summary>
/// <returns></returns>
/// 


namespace Cadastro_Pessoas.Classes
{
    public class PessoaJuridica : Pessoa, InterfacePessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";



        public override float PagarImpostos(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;
            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;
            }
            else
            {
                return rendimento * .09f;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if ((cnpj.Substring(8, 4) == "0001"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {

            VerificarPastaArquivo(caminho);

            string[] pjArrayString = { $"{pj.Nome}, {pj.Cnpj}, {pj.razaoSocial}, {pj.endereco}, {pj.Rendimento}" };

            File.AppendAllLines(caminho, pjArrayString);
        }
        public List<PessoaJuridica> LerArquivo()
        {

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] Linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in Linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }



    }
}