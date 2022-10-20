using BE7_FS4_UC12.Interfaces;

namespace BE7_FS4_UC12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
           DateTime dataAtual = DateTime.Today;
           double anos = (dataAtual - dataNasc).TotalDays /365;
           if(anos >= 18)
                return true;
           else
            return false;
        }
    


    public bool ValidarDataNascimento(string dataNasc)
    {
        DateTime dataConvertida;
        //verificar se a string esta em um formato válido
        if(DateTime.TryParse(dataNasc, out dataConvertida)){// TryParse tenta converter
            //Console.WriteLine($"{dataConvertida}");
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataConvertida).TotalDays /365;
            if(anos >=18){
                return true;
            }
            return false;

        
        }
        return false;
    }

    }
}