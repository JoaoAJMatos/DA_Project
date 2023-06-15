using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TopCinema.Models;

namespace TopCinema.Controllers
{
    internal class FuncionarioController
    {
        public static List<FuncionarioModel> GetFuncionarios()
        {
            using (var db = new CinemaContext())
            {
                return db.Funcionarios.ToList();
            }
        }

        public static void AddFuncionario(string nome, string morada, float salario, string funcao)
        {
            using (var db = new CinemaContext())
            {
                var funcionario = new FuncionarioModel(nome, morada, salario,funcao);
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }
        }

        public static void RemoveFuncionario(int idFuncionario)
        {
            using (var db = new CinemaContext())
            {
                var funcionario = db.Funcionarios.Find(idFuncionario);
                db.Funcionarios.Remove(funcionario);
                db.SaveChanges();
            }
        }

        public static void AlterarFuncionario(int idFuncionario, string nome, string morada, float salario, string funcao)
        {
            using (var db = new CinemaContext())
            {
                var funcionario = db.Funcionarios.Find(idFuncionario);
                funcionario.Nome = nome;
                funcionario.Morada = morada;
                funcionario.Salario = salario;
                funcionario.Funcao = funcao;
                db.SaveChanges();
            }
        }
    }
}
