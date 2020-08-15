using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    public class Pessoa
    {
        private string p_nome, p_sobrenome, p_cpf, p_rg, p_celular, p_telefone, p_sexo, p_d_nasc, p_email, p_senha;
        private string p_duv, p_resp, p_turma, p_professor, p_add1, p_add2, p_curso, p_cod_verificacao, p_obs;
        private int p_id_aluno, p_id_turma, p_id_ident, p_est, p_sel_query, p_id_login, p_id_curso, p_id_disciplina, p_id_conteudo, p_id_prof, p_id_duv, p_id_sim;
        private int p_nota, p_duracao, p_qtd_questao_correta;
        private bool p_val;
        private DateTime p_date; 

        public int id_aluno {get{return p_id_aluno;} set {p_id_aluno = value;}}
        public int id_login { get { return p_id_login; } set { p_id_login = value; } }
        public int estado { get { return p_est; } set { p_est = value; } }

        public string nome { get { return p_nome; } set { p_nome = value; } }
        public string sobrenome { get { return p_sobrenome; } set { p_sobrenome = value; } }
        public string cpf { get { return p_cpf; } set { p_cpf = value; } }
        public string rg { get { return p_rg; } set { p_rg = value; } }
        public string celular { get { return p_celular; } set { p_celular = value; } }
        public string Telefone { get { return p_telefone; } set { p_telefone = value; } }
        public string sexo { get { return p_sexo; } set { p_sexo = value; } }
        public string d_nasc { get { return p_d_nasc; } set { p_d_nasc = value; } }
        public string email { get { return p_email; } set { p_email = value; } }
        public string senha { get { return p_senha; } set { p_senha = value; } }
        public string cod_verificacao { get { return p_cod_verificacao; } set { p_cod_verificacao = value; } }



        public int id_duv { get { return p_id_duv; } set { p_id_duv = value; } }
        public string duv { get { return p_duv; } set { p_duv = value; } }
        public string resp { get { return p_resp; } set { p_resp = value; } }
        public string turma { get { return p_turma; } set { p_turma = value; } }
        public string professor { get { return p_professor; } set { p_professor = value; } }


        public string add1 { get { return p_add1; } set { p_add1 = value; } }
        public string add2 { get { return p_add2; } set { p_add2 = value; } }
        public string curso { get { return p_curso; } set { p_curso = value; } }




        public int id_turma { get { return p_id_turma; } set { p_id_turma = value; } }
        public int id_curso { get { return p_id_curso; } set { p_id_curso = value; } }
        public int id_ident { get { return p_id_ident; } set { p_id_ident = value; } }
        public int sel_query { get { return p_sel_query; } set { p_sel_query = value; } }
        public int id_disciplina { get { return p_id_disciplina; } set { p_id_disciplina = value; } }
        public int id_conteudo { get { return p_id_conteudo; } set { p_id_conteudo = value; } }
        public int id_prof { get { return p_id_prof; } set { p_id_prof = value; } }



        public bool val { get { return p_val; } set { p_val = value; } }
    
        
        public DateTime date { get { return p_date; } set { p_date = value; } }



        public int id_sim { get { return p_id_sim; } set { p_id_sim = value; } }
        public int nota { get { return p_nota; } set { p_nota = value; } }

        public int duracao { get { return p_duracao; } set { p_duracao = value; } }

        public string obs { get { return p_obs; } set { p_obs = value; } }
        public int qtd_questao_correta { get { return p_qtd_questao_correta; } set { p_qtd_questao_correta = value; } }

    }
}
