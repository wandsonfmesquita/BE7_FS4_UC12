using BE7_FS4_UC12.Interfaces;

namespace BE7_FS4_UC12.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public string ?endereco { get; set; }
        public string ?rendimento { get; set; }


        public abstract float PagarImposto(float rendimento);
        
    }

}