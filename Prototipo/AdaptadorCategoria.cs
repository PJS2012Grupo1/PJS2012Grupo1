using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class AdaptadorCategoria
    {
        //parametros
        private SqlParameter prmDescricaoCat = new SqlParameter();
        private SqlParameter prmOrcamento = new SqlParameter();
        private SqlParameter prmDescricaoCatAt = new SqlParameter();
        private SqlParameter prmOrcamentoAt = new SqlParameter();
        private SqlParameter prmCodigoCatAt = new SqlParameter();
        private SqlParameter prmCodigoCat = new SqlParameter();

        //adaptador
        public SqlDataAdapter adaptador = new SqlDataAdapter();

        private void configuraParametros()
        {
            prmDescricaoCat.ParameterName = "@DescricaoCat";
            prmDescricaoCat.SqlDbType = SqlDbType.VarChar;
            prmDescricaoCat.Size = 40;
            prmDescricaoCat.SourceColumn = "DescricaoCat";
            prmDescricaoCat.SourceVersion = DataRowVersion.Current;

            prmOrcamento.ParameterName = "@Orcamento";
            prmOrcamento.SqlDbType = SqlDbType.Decimal;
            prmOrcamento.SourceColumn = "Orcamento";
            prmOrcamento.SourceVersion = DataRowVersion.Current;

            prmDescricaoCatAt.ParameterName = "@DescricaoCat";
            prmDescricaoCatAt.SqlDbType = SqlDbType.VarChar;
            prmDescricaoCatAt.Size = 40;
            prmDescricaoCatAt.SourceColumn = "DescricaoCat";
            prmDescricaoCatAt.SourceVersion = DataRowVersion.Current;

            prmOrcamentoAt.ParameterName = "@Orcamento";
            prmOrcamentoAt.SqlDbType = SqlDbType.Decimal;
            prmOrcamentoAt.SourceColumn = "Orcamento";
            prmOrcamentoAt.SourceVersion = DataRowVersion.Current;

            prmCodigoCatAt.ParameterName = "@CodigoCat";
            prmCodigoCatAt.SqlDbType = SqlDbType.Int;
            prmCodigoCatAt.SourceColumn = "CodigoCat";
            prmCodigoCatAt.SourceVersion = DataRowVersion.Original;

            prmCodigoCat.ParameterName = "@CodigoCat";
            prmCodigoCat.SqlDbType = SqlDbType.Int;
            prmCodigoCat.SourceColumn = "CodigoCat";
            prmCodigoCat.SourceVersion = DataRowVersion.Original;
        }

        public AdaptadorCategoria()
        {
        }

        public AdaptadorCategoria(string conexaoString)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);

            configuraParametros();
            //Comando para a seleção de dados
            SqlCommand comandoSelecaoCat = new SqlCommand("Select * from Categoria", conexao);
            //Comando para a inserção de dados
            SqlCommand comandoInsercaoCat = new SqlCommand("Insert into Categoria (DescricaoCat, Orcamento) values (@DescricaoCat, @Orcamento)", conexao);
            comandoInsercaoCat.Parameters.Add(prmDescricaoCat);
            comandoInsercaoCat.Parameters.Add(prmOrcamento);
            //Comando para atualzação de dados
            SqlCommand comandoAtualizacaoCat = new SqlCommand("Update Categoria set DescricaoCat = @DescricaoCat, Orcamento = @Orcamento where CodigoCat = @CodigoCat", conexao);
            comandoAtualizacaoCat.Parameters.Add(prmDescricaoCatAt);
            comandoAtualizacaoCat.Parameters.Add(prmOrcamentoAt);
            comandoAtualizacaoCat.Parameters.Add(prmCodigoCatAt);
            //Comando para remoção de dados
            SqlCommand comandoRemocaoCat = new SqlCommand("Delete from Categoria where CodigoCat = @CodigoCat", conexao);
            comandoRemocaoCat.Parameters.Add(prmCodigoCat);

            //comandos do adaptador
            adaptador.SelectCommand = comandoSelecaoCat;
            adaptador.InsertCommand = comandoInsercaoCat;
            adaptador.UpdateCommand = comandoAtualizacaoCat;
            adaptador.DeleteCommand = comandoRemocaoCat;
        }
    }
}
