using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace WindowsFormsApp1
{
    public static partial class vars
    {
        public static string versao = "v.1.0.0";
        public static string pasta_dados;
        public static string base_dados;

        public static void Iniciar()
        {
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";

            //verifica se a pasta de dados existe, se não existe, cria a pasta de dados
            if (!Directory.Exists(pasta_dados))
                Directory.CreateDirectory(pasta_dados);

            //verifica se a base de dados existe, se não existe, cria o dados.sdf
            base_dados = pasta_dados + "dados.sdf";
            if (!File.Exists(base_dados))
                CriarBaseDados();
        }

        public static void CriarBaseDados()
        {
            //criação de base de dados
            SqlCeEngine motor = new SqlCeEngine("Data source = " + base_dados);
            motor.CreateDatabase();

            //criar estrutura do DB
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + base_dados);
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE contatos(id_contato int not null primary key, nome nvarchar(50), telefone nvarchar(20), atualizacao datetime)";

            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();
        }
    }
}
