using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Bliblioteca
{
    public class Paciente
    {
        public class Unit
        {
            [Required(ErrorMessage = "O prontuario é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "So aceita valores numericos")]
            [StringLength(4, MinimumLength = 4, ErrorMessage = "Deve possuir 4 digitos")]
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
            public string Genero { get; set; }
            [Required(ErrorMessage = "O UF é obrigatório")]
            public string UF { get; set; }
            [Required(ErrorMessage = "O email é obrigatório")]
            public string Email { get; set; }
            [Required(ErrorMessage = "O celular é obrigatório")]
            public string Cel { get; set; }
            public string Tel { get; set; }
            [Required(ErrorMessage = "O convenio é obrigatório")]
            public string Convenio { get; set; }
            [Required(ErrorMessage = "O numero da carterinha é obrigatório")]
            public string Carterinha { get; set; }
            [Required(ErrorMessage = "A validade é obrigatório")]
            public string Validade { get; set; }
            [Required(ErrorMessage = "A data de nascimento é obrigatório")]
            public string Nascimento { get; set; }

            public void validaClasse()
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

        public class List
        { 
            public List<Unit> ListUnit { get; set; }        
        }

        public static Unit DesSerialzedClassUnit(string vJson)

        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerialzedClassUnit(Unit unit)

        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
