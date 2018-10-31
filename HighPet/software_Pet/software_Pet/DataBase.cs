using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace software_Pet
{
    //Classe para Conexão com o Banco de Dados
    class DataBase
    {
        /*LBA01*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INFOLABS\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*LBA02*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INFOLABS\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*LAB03*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INFOLABS\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*PC-Doreto*/
        ///static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Doreto\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*PC-Nigga*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Niga\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*PC-André*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\André Victor\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        /*NOT-Aderley*/
        //static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Aderley\Documents\Visual Studio 2013\Projects\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        static string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\escola\TCC\DTCC\Projeto_Com_Interface - FINAL\Igor Gomes - Com Classe\software_Pet\BD_PETSHOP\BD_PETSHOP.mdf;Integrated Security=True;Connect Timeout=30";
        //Representando a conexão com o Banco de Dados
        private static SqlConnection conexao = null;

        //Método para Conectar no Banco de Dados
        public static SqlConnection obterConexao()
        {
            conexao = new SqlConnection(strcon);

            try
            {
                conexao.Close();
                conexao.Open();
            }
            catch
            {
                conexao = null;
            }

            return conexao;
        }

        //Método para Desconectar no Banco de Dados
        public static void fecharConexao()
        {
            if (conexao != null)
            {
                conexao.Close();
            }
        }
    }
}
