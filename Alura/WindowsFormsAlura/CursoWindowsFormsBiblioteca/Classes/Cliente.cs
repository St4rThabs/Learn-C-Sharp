using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.Classes.Databases;
using CursoWindowsFormsBiblioteca.Databases;
using System.Data;

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
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai do Cliente deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome da Mãe do Cliente deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public int NaoTemPai { get; set; }

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
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais.");
                }

                if (this.NaoTemPai == 1)
                {
                    if (this.NomePai == "")
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

            #region CRUD do Fichario
            public void IncluirFichario(string Conexao)
            {
                string clienteJson = SerializedClassUnit(this);
                Fichario F = new Fichario(Conexao);

                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public Unit BuscarFichario(string id, string conexao)
            {
                Fichario F = new Fichario(conexao);

                if (F.status)
                {
                    string clienteJson = F.Buscar(id);

                    return DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);

                Fichario F = new Fichario("C:\\Users\\thabata.lima\\source\\repos\\WindowsFormsAlura\\Fichario");

                if (F.status)
                {
                    F.Alterar(Id, clienteJson);

                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }
                else
                    throw new Exception(F.mensagem);
            }

            public void ApagarFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);

                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }
                else
                    throw new Exception(F.mensagem);

            }

            public List<string> ListaFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);

                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }

                else
                    throw new Exception(F.mensagem);
            }
            #endregion

            #region CRUD do FicharioDB
            public void IncluirFicharioDB(string conexao)
            {
                string clienteJson = SerializedClassUnit(this);
                FicharioDB F = new FicharioDB(conexao);

                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public Unit BuscarFicharioDB(string id, string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);

                if (F.status)
                {
                    string clienteJson = F.Buscar(id);

                    return DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);

                FicharioDB F = new FicharioDB(conexao);

                if (F.status)
                {
                    F.Alterar(Id, clienteJson);

                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }

                else
                    throw new Exception(F.mensagem);

            }
            public void ApagarFicharioDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);

                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }
                else
                    throw new Exception(F.mensagem);

            }

            public List<List<string>> BuscarFicharioTodosDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();

                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Unit C = DesSerializedClassUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion

            #region CRUD do Fichario SQL Server
            public void IncluirFicharioSQL(string conexao)
            {
                string clienteJson = SerializedClassUnit(this);
                FicharioSQLServer F = new FicharioSQLServer(conexao);

                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public Unit BuscarFicharioSQL(string id, string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);

                if (F.status)
                {
                    string clienteJson = F.Buscar(id);

                    return DesSerializedClassUnit(clienteJson);
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            public void AlterarFicharioSQL(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);

                FicharioSQLServer F = new FicharioSQLServer(conexao);

                if (F.status)
                {
                    F.Alterar(Id, clienteJson);

                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }

                else
                    throw new Exception(F.mensagem);

            }
            public void ApagarFicharioSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);

                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                        throw new Exception(F.mensagem);
                }
                else
                    throw new Exception(F.mensagem);

            }

            public List<List<string>> BuscarFicharioTodosSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();

                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Unit C = DesSerializedClassUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion

            #region CRUD do Fichario SQL Server Relacional

            #region Funções Auxiliares
            public string ToInsert()
            {
                string SQL;
                SQL = @"INSERT INTO TB_Cliente
                    (Id,
                    Nome,
                    NomePai,
                    NomeMae,
                    NaoTemPai,
                    Cpf,Genero,
                    Cep,
                    Logradouro,
                    Complemento,
                    Bairro,
                    Cidade,
                    Estado,
                    Telefone,
                    Profissao,
                    RendaFamiliar)
                    VALUES ";

                SQL += "('" + Id + "'," +
                "'" + Nome + "'," +
                "'" + NomePai + "'," +
                "'" + NomeMae + "'," +
                Convert.ToString(NaoTemPai) + "," +
                "'" + Cpf + "'," +
                Convert.ToString(Genero) + "," +
                "'" + Cep + "'," +
                "'" + Logradouro + "'," +
                "'" + Complemento + "'," +
                "'" + Bairro + "'," +
                "'" + Cidade + "'," +
                "'" + Estado + "'," +
                "'" + Telefone + "'," +
                "'" + Profissao + "'," +
                Convert.ToString(RendaFamiliar) + ");";

                return SQL;
            }

            public string ToUpdate(string Id)
            {
                string SQL;

                SQL = @"UPDATE TB_Cliente SET " +
                "Id = '" + this.Id + "'" +
                " , Nome = '" + Nome + "'" +
                " , NomePai = '" + NomePai + "'" +
                " , NomeMae = '" + NomeMae + "'" +
                " , NaoTemPai = " + Convert.ToString(NaoTemPai) + "" +
                " , Cpf = '" + Cpf + "'" +
                " , Genero = " + Convert.ToString(Genero) + "" +
                " , Cep = '" + Cep + "'" +
                " , Logradouro = '" + Logradouro + "'" +
                " , Complemento = '" + Complemento + "'" +
                " , Bairro = '" + Bairro + "'" +
                " , Cidade = '" + Cidade + "'" +
                " , Estado = '" + Estado + "'" +
                " , Telefone = '" + Telefone + "'" +
                " , Profissao = '" + Profissao + "'" +
                " , RendaFamiliar = " + Convert.ToString(RendaFamiliar) + "" +
                " WHERE Id = '" + Id + "';";

                return SQL;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();

                u.Id = dr["Id"].ToString();
                u.Nome = dr["Nome"].ToString();
                u.NomePai = dr["NomePai"].ToString();
                u.NomeMae = dr["NomeMae"].ToString();
                u.NaoTemPai = Convert.ToInt32(dr["NaoTemPai"]);
                u.Cpf = dr["Cpf"].ToString();
                u.Genero = Convert.ToInt32(dr["Genero"]);
                u.Cep = dr["Cep"].ToString();
                u.Logradouro = dr["Logradouro"].ToString();
                u.Complemento = dr["Complemento"].ToString();
                u.Bairro = dr["Bairro"].ToString();
                u.Cidade = dr["Cidade"].ToString();
                u.Estado = dr["Estado"].ToString();
                u.Telefone = dr["Telefone"].ToString();
                u.Profissao = dr["Profissao"].ToString();
                u.RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"]);

                return u;
            }
            #endregion

            #endregion
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
