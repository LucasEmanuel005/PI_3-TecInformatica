using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PI
{
    public class controle
    {
        public bool tem;
        public String mensagem = "";
        public int id_user = 0, id_turma=0;
        public int id_ident_p_a_cont = 0;
        LoginDalCom loginDal = new LoginDalCom();
        Pessoa pessoa = new Pessoa();
        DataTable datT_c = new DataTable();

        public Pessoa acessar(Pessoa pess) 
        {
            pessoa = pess;
            pessoa = loginDal.verificarLogin(pess);        
          
            return pessoa;
        
        }


        public String pesq_frase() 
        {
            return loginDal.pesq_frase();
        }
        public Pessoa Pesq_duv(Pessoa pess) 
        {
            pessoa = pess;
            pessoa = loginDal.pesq_duv(pessoa);          
            return pessoa;
        }
        public String pesq_graf(Pessoa pess)
        {
            string res = "";
            return res;
        }
       
        public DataTable pesquisa(Pessoa pess)
        {
            pessoa = pess;
            datT_c  = loginDal.pesquisa_LogDal(pessoa);
            return datT_c;
        }
        public Pessoa cadastrar(Pessoa pess)
        {
            pessoa = pess;
            pessoa = loginDal.cadastrar_LoginDal(pess);
            return pessoa;
        }

        public Pessoa Insert_aula(Pessoa pess)
        {
            pessoa = pess;
            pessoa = loginDal.Insert_aula_loginDal(pessoa);
            return pessoa;
        }
        public Pessoa ver_login(Pessoa pess)
        {

            return pessoa;
        }

        public Pessoa deletar(Pessoa pess) 
        {
            pessoa = pess;
            loginDal.deletar_loginDal(pessoa);


            return pessoa;
        }
        public Pessoa Update(Pessoa pess)
        {
            pessoa = pess;
            loginDal.update_LoginDal(pessoa);
            return pessoa;
        }


    }
}
