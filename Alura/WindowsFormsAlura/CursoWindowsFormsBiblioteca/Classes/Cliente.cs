using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            // um único cliente
            #region dados pessoais do cliente
            [Required(ErrorMessage = "Código do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores númericos.")]
            [StringLength(6, MinimumLength = 6 , ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai do Cliente deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome da Mãe do Cliente deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF do Cliente é obrigatório.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do Cliente deve ter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Gênero do Cliente é obrigatório.")]
            public int Genero { get; set; }
            #endregion

            #region dados de moradia
            [Required(ErrorMessage = "CEP do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP do Cliente somente aceita valores númericos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do Cliente deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro do Cliente é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro do Cliente deve ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento do Cliente é obrigatório.")]
            [StringLength(100, ErrorMessage = "Complemento do Cliente deve ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro do Cliente deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Cidade do Cliente deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Estado do Cliente deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }
            #endregion

            #region outros
            [Required(ErrorMessage = "Número do telefone do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Número do telefone do Cliente somente aceita valores númericos.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar do Cliente é obrigatório.")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo")]
            public Double RendaFamiliar { get; set; }
            #endregion

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

            public void ValidaComplemento()
            {
                if(this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais.");
                }

                if(this.NaoTemPai == false)
                {
                    if(this.NomePai == "")
                    {
                        throw new Exception("Nome do pai não pode estar vazio quando a propriedade pai desconhecido não estiver marcado.");
                    }
                }

                bool validaCpf = Cls_Uteis.Valida(this.Cpf);

                if (validaCpf == false)
                {
                    throw new Exception("CPF inválido");
                }
            }
        }

        public class List
        {
            // uma lista de clientes
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
