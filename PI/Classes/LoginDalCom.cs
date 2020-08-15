using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PI
{
    class LoginDalCom
    {
        
        public String mensagem = "", frase = "";
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd_dv = new MySqlCommand();
        conexao conex = new conexao();
        MySqlDataReader dr, dr_duv;
        Pessoa pess = new Pessoa();
        DataTable datT;
        MySqlDataAdapter arraAd;
        string query = "";

       


        //PESQUISA RETORNA CLASSE PESSOA
        public Pessoa verificarLogin(Pessoa pessoa)
        {
            pess = pessoa;      
            pess.val = false;

            try
            {
                switch (pess.sel_query)
                {
                    case 1:
                        cmd.CommandText = "SELECT a.id_aluno AS 'id', a.nome, l.email, l.senha, ipa.*  FROM aluno AS a JOIN login AS l ON a.FK_LOGIN_id_login = l.id_login JOIN ident_pro_alu AS ipa ON l.FK_IDENT_PRO_ALU_id_ident_pro_alu = ipa.id_ident_pro_alu  WHERE l.email = @email AND l.senha = @senha "
                + "UNION" + " SELECT p.id_professor, p.nome, l.email, l.senha, ipa.* FROM professor AS p JOIN login AS l ON p.FK_LOGIN_id_login = l.id_login JOIN ident_pro_alu AS ipa ON l.FK_IDENT_PRO_ALU_id_ident_pro_alu = ipa.id_ident_pro_alu  WHERE l.email = @email AND l.senha = @senha ";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        cmd.Parameters.AddWithValue("@@senha", pess.senha);
                        break;
                    case 2:
                        cmd.CommandText = "SELECT * FROM login WHERE email = @email";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        break;
                    case 3:
                        cmd.CommandText = "SELECT * FROM aluno WHERE cpf = @cpf ";
                        cmd.Parameters.AddWithValue("@@cpf", pess.cpf);
                        break;
                    case 5:
                        cmd.CommandText = "SELECT * FROM login WHERE email = @email ";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        break;

                    case 6:
                        cmd.CommandText = "SELECT * FROM login WHERE email=@email";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        break;
                    case 7:
                        cmd.CommandText = "SELECT d.pergunta, d.resposta, p.nome FROM duvida AS d " +
                            " JOIN aluno AS a ON d.FK_ALUNO_id_aluno = a.id_aluno " +
                            " JOIN turma AS t ON t.id_turma = d.FK_TURMA_id_turma " +
                            " JOIN professor AS p ON d.FK_PROFESSOR_id_professor = p.id_professor " +
                            " WHERE a.id_aluno = @id_aluno AND t.id_turma = @id_turma ORDER BY d.id_duvida DESC LIMIT 1";                        
                        cmd.Parameters.AddWithValue("@@id_aluno", pess.id_aluno);
                        cmd.Parameters.AddWithValue("@@id_turma", pess.id_turma);
                        break;
                    case 8:
                        cmd.CommandText = "SELECT * FROM login WHERE email= @email AND senha= @senha";                       
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        cmd.Parameters.AddWithValue("@@senha", pess.senha);
                        break;
                    case 9:
                        cmd.CommandText = "SELECT * FROM professor p JOIN login l ON p.FK_LOGIN_id_login = l.id_login WHERE id_login = @id_login";
                        cmd.Parameters.AddWithValue("@@id_login", pess.id_aluno);                        
                        break;
                }

                cmd.Connection = conex.conectar();
                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    pess.val = true;
                    if (pess.sel_query == 1)
                    {
                        dr.Read();

                        pess.nome = dr["nome"].ToString();
                        pess.id_ident = int.Parse(dr["id_ident_pro_alu"].ToString());
                        //ALUNO
                        pess.id_aluno = int.Parse(dr["id"].ToString());                            
                        //PROFESSOR
                        pess.id_prof = int.Parse(dr["id"].ToString());
                        


                    }
                    else if (pess.sel_query == 6) 
                    {
                        dr.Read();
                        pess.cod_verificacao = dr["Cod_Nw_sen"].ToString();
                    }
                    else if (pess.sel_query == 7)
                    {
                        dr.Read();
                        pess.duv = dr["pergunta"].ToString();
                        pess.resp = dr["resposta"].ToString();
                        pess.professor = dr["nome"].ToString();
                    }
                    else if (pess.sel_query == 9)
                    {
                        dr.Read();
                        pess.nome = dr["nome"].ToString();
                    }
                }
                else
                {
                    pess.val = false;
                }
                cmd.Parameters.Clear();
                conex.desconectar();

            }
            catch
            {
                pess.add1 = "erro";
            }
        
            
            return pess;
        }

        //PESQUISA RETORNA TABLE
        public DataTable pesquisa_LogDal(Pessoa pessoa)
        {

            pess = pessoa;

            switch (pess.sel_query)
            {
                case 1:
                    query = "SELECT a.nome, t.id_turma, t.sigla FROM aluno a JOIN matricula m ON m.FK_ALUNO_id_aluno = a.id_aluno JOIN turma t ON m.FK_TURMA_id_turma = t.id_turma WHERE a.id_aluno= " + pess.id_aluno; //+ " AND t.situacao = true"
                    break;

                case 2:
                    query = "SELECT * FROM estado;";
                    break;
                case 3:
                    query = "SELECT c.id_curso, c.nome, t.id_turma, DATE_FORMAT(d_ini,'%d/%m/%Y') AS d_inicio_f, " +
                            "DATE_FORMAT(d_fim, '%d/%m/%Y') AS d_fim_f, t.preco, t.sigla, t.FK_CURSO_id_curso, " +
                            "t.situacao, t.vaga FROM curso c JOIN turma t ON c.id_curso = t.FK_CURSO_id_curso WHERE t.situacao = true AND c.id_curso= " + pess.id_curso;
                    break;
                case 4:
                    query = "SELECT * FROM curso";
                    break;
                case 5:
                    query = "SELECT d.id_disciplina, d.nome FROM monitorada_TURMA_PROFESSOR_DISCIPLINA mTPD JOIN turma t " +
                        "ON mTPD.FK_TURMA_id_turma = t.id_turma JOIN matricula m ON m.FK_TURMA_id_turma = t.id_turma" +
                        " JOIN aluno a ON m.FK_ALUNO_id_aluno = a.id_aluno JOIN disciplina d ON mTPD.FK_DISCIPLINA_id_disciplina = d.id_disciplina" +
                        " WHERE a.id_aluno = " + pess.id_aluno + " AND t.id_turma = " + pess.id_turma;                    
                    break;
                case 6:                    
                    query = "SELECT c.* " +
                        " FROM monitorada_TURMA_PROFESSOR_DISCIPLINA mTPD JOIN turma t " +
                        "ON mTPD.FK_TURMA_id_turma = t.id_turma JOIN matricula m ON m.FK_TURMA_id_turma = t.id_turma " +
                        "JOIN aluno a ON m.FK_ALUNO_id_aluno = a.id_aluno JOIN disciplina d " +
                        "ON mTPD.FK_DISCIPLINA_id_disciplina = d.id_disciplina JOIN conteudo c " +
                        "ON c.FK_DISCIPLINA_id_disciplina = d.id_disciplina " +
                        " WHERE a.id_aluno = " + pess.id_aluno + " AND t.id_turma = " + pess.id_turma +
                        " AND d.id_disciplina = " + pess.id_disciplina;
                    break;
                case 7:

                    query = "SELECT c.* " +
                        " FROM monitorada_TURMA_PROFESSOR_DISCIPLINA mTPD JOIN turma t " +
                        "ON mTPD.FK_TURMA_id_turma = t.id_turma JOIN matricula m ON m.FK_TURMA_id_turma = t.id_turma " +
                        "JOIN aluno a ON m.FK_ALUNO_id_aluno = a.id_aluno JOIN disciplina d " +
                        "ON mTPD.FK_DISCIPLINA_id_disciplina = d.id_disciplina JOIN conteudo c " +
                        "ON c.FK_DISCIPLINA_id_disciplina = d.id_disciplina " +
                        " WHERE a.id_aluno = " + pess.id_aluno + " AND t.id_turma = " + pess.id_turma +
                        " AND d.id_disciplina = " + pess.id_disciplina + "  AND c.nome LIKE '" + pess.add2 + "%'";
                    break;
                case 8:
                    query = "SELECT p.id_professor, p.nome, d.nome " +
                        " FROM monitorada_TURMA_PROFESSOR_DISCIPLINA mTPD " +
                        " JOIN turma t ON mTPD.FK_TURMA_id_turma = t.id_turma " +
                        " JOIN matricula m ON m.FK_TURMA_id_turma = t.id_turma " +
                        " JOIN aluno a ON m.FK_ALUNO_id_aluno = a.id_aluno " +
                        " JOIN disciplina d ON mTPD.FK_DISCIPLINA_id_disciplina = d.id_disciplina " +
                        " JOIN professor p  ON mTPD.FK_PROFESSOR_id_professor = p.id_professor " +
                        " WHERE a.id_aluno = " + pess.id_aluno + " AND t.id_turma = " + pess.id_turma +
                        " AND d.id_disciplina = " + pess.id_disciplina;
                    break;
                case 9:
                    query = "SELECT DISTINCT  d.nome, d.id_disciplina FROM curso c " +
                        "JOIN conteudo ct ON c.id_curso = ct.FK_CURSO_id_curso " +
                        "JOIN disciplina d ON  d.id_disciplina = ct.FK_DISCIPLINA_id_disciplina " +
                        "WHERE c.id_curso = "+ pess.id_curso;
                    break;
                case 10:
                    query = "SELECT ct.nome, ct.h_total FROM curso c " +
                        "JOIN conteudo ct ON c.id_curso = ct.FK_CURSO_id_curso " +
                        "JOIN disciplina d ON  d.id_disciplina = ct.FK_DISCIPLINA_id_disciplina " +
                        "WHERE c.id_curso = " + pess.id_curso + " AND d.id_disciplina = " + pess.id_disciplina;
                    break;

                case 11:
                    query = "SELECT p.id_professor, p.nome FROM monitorada_turma_professor_disciplina mtpd " +
                        " JOIN Professor p ON mtpd.FK_PROFESSOR_id_professor = p.id_professor" +
                        " WHERE FK_TURMA_id_turma = "+ pessoa.id_turma;	
                    break;
                case 12:                   
                    query = "SELECT d.pergunta, d.resposta, p.nome, d.dat  FROM duvida AS d " +
                            " JOIN aluno AS a ON d.FK_ALUNO_id_aluno = a.id_aluno " +
                            " JOIN turma AS t ON t.id_turma = d.FK_TURMA_id_turma " +
                            " JOIN professor AS p ON d.FK_PROFESSOR_id_professor = p.id_professor"+
                            " WHERE a.id_aluno = " + pessoa.id_aluno +" AND t.id_turma = " + pessoa.id_turma +" ORDER BY d.id_duvida DESC LIMIT 5";
                    break;
                case 13:
                    query = "SELECT d.pergunta, d.resposta, p.nome, d.dat FROM duvida AS d " +
                           " JOIN aluno AS a ON d.FK_ALUNO_id_aluno = a.id_aluno " +
                           " JOIN turma AS t ON t.id_turma = d.FK_TURMA_id_turma " +
                           " JOIN professor AS p ON d.FK_PROFESSOR_id_professor = p.id_professor" +
                           " WHERE a.id_aluno = " + pessoa.id_aluno + " AND t.id_turma = " + pessoa.id_turma + " ORDER BY d.id_duvida DESC";
                    break;
                //DUVIDA PROF 
                case 14:
                    query = "SELECT d.id_duvida, d.pergunta, d.resposta, a.id_aluno, a.nome, d.dat FROM duvida AS d " +
                        "JOIN aluno AS a ON d.FK_ALUNO_id_aluno = a.id_aluno " +
                        "JOIN turma AS t ON t.id_turma = d.FK_TURMA_id_turma " +
                        "JOIN professor AS p ON d.FK_PROFESSOR_id_professor = p.id_professor " +
                        "WHERE p.id_professor = " + pessoa.id_prof + " ORDER BY d.id_duvida DESC LIMIT 50";
                        break;
                case 15:
                    query = "SELECT * FROM evento WHERE Organizador1 = "+ pessoa.id_prof + " OR Organizador2 = "+ pessoa.id_prof + " ORDER BY dat DESC";
                    break;

                //DUVIDA PROF 
                case 16:
                   query = "SELECT d.id_duvida, d.pergunta, d.resposta, a.id_aluno, a.nome, d.dat FROM duvida AS d " +
                         "JOIN aluno AS a ON d.FK_ALUNO_id_aluno = a.id_aluno " +
                         "JOIN turma AS t ON t.id_turma = d.FK_TURMA_id_turma " +
                         "JOIN professor AS p ON d.FK_PROFESSOR_id_professor = p.id_professor " +
                         "WHERE p.id_professor = " + pessoa.id_prof + " ORDER BY d.id_duvida DESC ";
                    break;
                    //EXAME 
                case 17:
                    query = "SELECT * FROM questoes WHERE FK_SIMULADO_id_simulado = " + pessoa.id_sim;
                    break;
                case 18:
                    query = "SELECT * FROM simulado";
                    break;
                case 19:
                    query = "SELECT * FROM evento";
                    break;



            }

            MySqlConnection con = new MySqlConnection("server = localhost; database = bd_VestATM; user id = root; Password = ");
            cmd = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter exe = new MySqlDataAdapter();
                exe.SelectCommand = cmd;
                DataTable table = new DataTable();
                exe.Fill(table);
                return table;               
            }
            catch (Exception erro)
            {
                throw erro;

            }

        }
        


        public Pessoa cadastrar_LoginDal(Pessoa pessoa)
        {
            pess = pessoa;            
            pess.add1 = "erro";

            try
            {
                switch (pess.sel_query)
                {
                    case 1:
                        cmd.CommandText = "INSERT INTO login (email, senha, FK_IDENT_PRO_ALU_id_ident_pro_alu) VALUES (@email, @senha, @ident)";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        cmd.Parameters.AddWithValue("@@senha", pess.senha);
                        cmd.Parameters.AddWithValue("@@ident", pess.id_ident);
                        break;
                   
                    case 2:

    cmd.CommandText = "INSERT INTO aluno (nome, sobrenome, rg, cpf, telefone, celular, d_nasc, sexo, FK_LOGIN_id_login, FK_ESTADO_id_estado) VALUES" +
                            " (@nome, @sobrenome, @rg, @cpf, @Telefone, @celular, @d_nasc, @sexo, @id_login, @estado)";
                        cmd.Parameters.AddWithValue("@@nome", pess.nome);
                        cmd.Parameters.AddWithValue("@@sobrenome", pess.sobrenome);
                        cmd.Parameters.AddWithValue("@@rg", pess.rg);
                        cmd.Parameters.AddWithValue("@@cpf", pess.cpf);
                        cmd.Parameters.AddWithValue("@@Telefone", pess.Telefone);
                        cmd.Parameters.AddWithValue("@@celular", pess.celular);                        
                        cmd.Parameters.AddWithValue("@@d_nasc", pess.d_nasc);
                        cmd.Parameters.AddWithValue("@@sexo", pess.sexo);
                        cmd.Parameters.AddWithValue("@@id_login", pess.id_login);
                        cmd.Parameters.AddWithValue("@@estado", pess.estado);


                        break;
                    case 3:
                        cmd.CommandText = "INSERT INTO matricula (d_matricula, FK_ALUNO_id_aluno,  FK_TURMA_id_turma) VALUES (@date, @id_aluno, @id_turma)";
                        cmd.Parameters.AddWithValue("@@date", pess.date);
                        cmd.Parameters.AddWithValue("@@id_aluno", pess.id_aluno);
                        cmd.Parameters.AddWithValue("@@id_turma", pess.id_turma);
                        break;
                    case 4:
                        cmd.CommandText = "INSERT INTO resultado (duracao, qtd_questao_correta, FK_ALUNO_id_aluno, FK_SIMULADO_id_simulado)" +
                            " VALUES (@duracao, @qtd_questao_correta, @FK_ALUNO_id_aluno, @FK_SIMULADO_id_simulado)";                      
                        cmd.Parameters.AddWithValue("@@duracao", pess.duracao);                      
                        cmd.Parameters.AddWithValue("@@qtd_questao_correta", pess.qtd_questao_correta);
                        cmd.Parameters.AddWithValue("@@FK_ALUNO_id_aluno", pess.id_aluno);
                        cmd.Parameters.AddWithValue("@@FK_SIMULADO_id_simulado", pess.id_sim);
                        break;
                }
                cmd.Connection = conex.conectar();
                int resp = cmd.ExecuteNonQuery();
                if(resp == 1)
                {
                    pess.add1 = "sucesso";


                    if (pess.sel_query == 1)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM login WHERE email = @email AND senha = @senha";
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        cmd.Parameters.AddWithValue("@@senha", pess.senha);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            pess.val = true;

                            dr.Read();
                            pess.id_login = int.Parse(dr["id_login"].ToString());

                        }
                        else
                        {
                            pess.val = false;
                        }
                    }
                    else if (pess.sel_query == 2)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM aluno WHERE nome = @nome AND sobrenome = @sobrenome AND cpf = @cpf";
                        cmd.Parameters.AddWithValue("@@nome", pess.nome);
                        cmd.Parameters.AddWithValue("@@sobrenome", pess.sobrenome);
                        cmd.Parameters.AddWithValue("@@cpf", pess.cpf);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            pess.val = true;

                            dr.Read();
                            pess.id_aluno = int.Parse(dr["id_aluno"].ToString());

                        }
                        else
                        {
                            pess.val = false;
                        }
                    }
                    cmd.Parameters.Clear();
                    conex.desconectar();


                }
            }
            catch {
                pess.add1 = "erro";
            }
            
            return pess;
        }

        public Pessoa Insert_aula_loginDal(Pessoa pessoa)
        {
            pess = pessoa;
         


            try
            {
                switch (pess.sel_query)
                {
                    case 1:
                        cmd.CommandText = "INSERT INTO duvida (pergunta, resposta, FK_ALUNO_id_aluno, FK_TURMA_id_turma, FK_PROFESSOR_id_professor, dat) " +
                            "VALUES (@perg, @resp, @id_aluno, @id_turma, @id_prof, @dat)";
                        cmd.Parameters.AddWithValue("@@perg", pess.duv);
                        cmd.Parameters.AddWithValue("@@resp", pess.resp);
                        cmd.Parameters.AddWithValue("@@id_aluno", pess.id_aluno);
                        cmd.Parameters.AddWithValue("@@id_turma", pess.id_turma);
                        cmd.Parameters.AddWithValue("@@id_prof", pess.id_prof);
                        cmd.Parameters.AddWithValue("@@dat", pess.date);
                        break;

                    case 2:

                        cmd.CommandText = "INSERT INTO aluno (nome, sobrenome, rg, cpf, telefone, celular, d_nasc, sexo, FK_LOGIN_id_login, FK_ESTADO_id_estado) VALUES" +
                                                " (@nome, @sobrenome, @rg, @cpf, @Telefone, @celular, @d_nasc, @sexo, @id_login, @estado)";
                        cmd.Parameters.AddWithValue("@@nome", pess.nome);
                        cmd.Parameters.AddWithValue("@@sobrenome", pess.sobrenome);
                        cmd.Parameters.AddWithValue("@@rg", pess.rg);
                        cmd.Parameters.AddWithValue("@@cpf", pess.cpf);
                        cmd.Parameters.AddWithValue("@@Telefone", pess.Telefone);
                        cmd.Parameters.AddWithValue("@@celular", pess.celular);
                        cmd.Parameters.AddWithValue("@@d_nasc", pess.d_nasc);
                        cmd.Parameters.AddWithValue("@@sexo", pess.sexo);
                        cmd.Parameters.AddWithValue("@@id_login", pess.id_login);
                        cmd.Parameters.AddWithValue("@@estado", pess.estado);


                        break;
                }
                cmd.Connection = conex.conectar();
                int resp = cmd.ExecuteNonQuery();
                if (resp == 1)
                {
                    pess.add1 = "sucesso";                  
                    
                    cmd.Parameters.Clear();
                    conex.desconectar();


                }
            }
            catch
            {
                pess.add1 = "erro";
            }

            return pess;
        }





        public String pesq_frase()
        {
            //FUNCAO QUE GERA UM NUMERO ALEATORIO P BUSCAR NO BANCO UMA FRASE
            Random num = new Random();
            int n = num.Next(1, 7);
            cmd.CommandText = "SELECT f.descricao, a.nome FROM frase AS f JOIN autor AS a ON f.FK_AUTOR_id_autor = a.id_autor WHERE id_frase = " + n;
            try
            {
                cmd.Connection = conex.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    frase = dr["descricao"].ToString() + "        " + dr["nome"].ToString();  
                }
                cmd.Parameters.Clear();
            conex.desconectar();

            }
             
            catch
            {
                frase = "Não procure estudar mais. Procure aprender mais. Prof.Leandro Piccini";
            }

            

            return frase;


        }
       
     

        public DataTable pesq_graf_dal(Pessoa pessoa)
        {
            pess = pessoa;
            cmd.CommandText = "SELECT duracao FROM aula WHERE FK_ALUNO_id_aluno = @id_aluno AND FK_TURMA_id_turma = 1 LIMIT 100";




            switch (pess.sel_query)
            {
                case 1:
                    query = "SELECT a.nome, t.id_turma, t.sigla FROM aluno a JOIN matricula m ON m.FK_ALUNO_id_aluno = a.id_aluno JOIN turma t ON m.FK_TURMA_id_turma = t.id_turma WHERE a.id_aluno= " + pess.id_aluno; //+ " AND t.situacao = true"
                    break;

                case 2:
                    query = "SELECT * FROM estado;";
                    break;
                case 3:
                    query = "SELECT c.id_curso, c.nome, t.id_turma, DATE_FORMAT(d_ini,'%d/%m/%Y') AS d_inicio_f, " +
                            "DATE_FORMAT(d_fim, '%d/%m/%Y') AS d_fim_f, t.preco, t.sigla, t.FK_CURSO_id_curso, " +
                            "t.situacao, t.vaga FROM curso c JOIN turma t ON c.id_curso = t.FK_CURSO_id_curso WHERE t.situacao = true AND c.id_curso= " + pess.id_curso;
                    break;
                case 4:
                    query = "SELECT * FROM curso";
                    break;

            }

            MySqlConnection con = new MySqlConnection("server = localhost; database = bd_VestATM; user id = root; Password = ");
            cmd = new MySqlCommand(query, con);

            try
            {
                MySqlDataAdapter exe = new MySqlDataAdapter();
                exe.SelectCommand = cmd;
                DataTable table = new DataTable();
                exe.Fill(table);

                return table;

               
            }
            catch (Exception erro)
            {
                throw erro;

            }




            return datT;
        }


          

        public Pessoa deletar_loginDal(Pessoa pessoa) 
        {
            pess = pessoa;
            try
            {
                switch (pess.sel_query)
                {
                    case 1:
                        cmd.CommandText = "DELETE FROM login WHERE id_login = @id_login";
                        cmd.Parameters.AddWithValue("@@id_login", pess.id_login);
                        break;
                }

                cmd.Connection = conex.conectar();
                int resp = cmd.ExecuteNonQuery();
                if (resp == 1)
                {
                    pess.val = true;
                }
            }
            catch
            {
                pess.val = false;
            }
            return pess;
        }





        public Pessoa update_LoginDal(Pessoa pessoa)
        {
            pess = pessoa;
          
            try
            {
                switch (pess.sel_query)
                {
                    case 1:                       
                        cmd.CommandText = "UPDATE login SET senha = @senha WHERE email = @email";
                        cmd.Parameters.AddWithValue("@@senha", pess.senha);
                        cmd.Parameters.AddWithValue("@@email", pess.email);
                        break;
                    case 2:                       
                        cmd.CommandText = "UPDATE duvida SET resposta = @resp WHERE id_duvida = @id_duv";
                        cmd.Parameters.AddWithValue("@@resp", pess.resp);
                        cmd.Parameters.AddWithValue("@@id_duv", pess.id_duv);
                        break;


                }
                cmd.Connection = conex.conectar();
                int resp = cmd.ExecuteNonQuery();
                if (resp == 1)
                {
                    pess.add1 = "sucesso";

                    cmd.Parameters.Clear();
                    conex.desconectar();


                }
            }
            catch
            {
                pess.add1 = "erro";
            }

            return pess;
        }




    }
}