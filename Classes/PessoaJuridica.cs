using BE7_FS4_UC12.Interfaces;
using System.Text.RegularExpressions;

namespace BE7_FS4_UC12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string razaoSocial { get; set; }
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        
    public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}))"))
            {
                if(cnpj.Length == 18)
                {
                    if(cnpj.Substring(11,4) == "0001")
                    {
                        return true;

                    }

                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001")
                    {
                        return true;

                    }

                }
            }        
        return false;
        }
    }
}