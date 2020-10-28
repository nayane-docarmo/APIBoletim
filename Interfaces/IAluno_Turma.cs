using APIBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Interfaces
{
    interface IAluno_Turma
    {
        Aluno_Turma Cadastrar(Aluno_Turma a);
        List<Aluno_Turma> LerTodos();
        Aluno_Turma BuscarPorId(int id);
        Aluno_Turma Alterar(Aluno_Turma a);
        Aluno_Turma Excluir(Aluno_Turma a);


    }
}
