using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Blibliotecas
{
    internal class Paciente
    {
        [Required(ErrorMessage = "O prontuario é obrigatório")]
        public string Prontuario { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sobrenome é obrigatório")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O RG é obrigatório")]
        public string RG { get; set; }
        [Required(ErrorMessage = "O genero é obrigatório")]
        public int Genero { get; set; }
        [Required(ErrorMessage = "O UF é obrigatório")]
        public int UF { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O celular é obrigatório")]
        public string Cel { get; set; }
        public string Tel { get; set; }
        [Required(ErrorMessage = "O convenio é obrigatório")]
        public string Convenio { get; set; }
        [Required(ErrorMessage = "O numero da carterinha é obrigatório")]
        public string Carterinha { get; set; }
        [Required(ErrorMessage = "A valiadade é obrigatório")]
        public string Validade { get; set; }

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }

        }

    }
}
