using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class AdaptadorRegistros
    {
        //parametros
        private SqlParameter prmDescricao = new SqlParameter();
        private SqlParameter prmValor = new SqlParameter();
        private SqlParameter prmCategoria = new SqlParameter();
        private SqlParameter prmRecorrente = new SqlParameter();
        private SqlParameter prmDataVencimento = new SqlParameter();
        private SqlParameter prmDataPagamento = new SqlParameter();
        private SqlParameter prmDataCadastro = new SqlParameter();
        private SqlParameter prmCodigo = new SqlParameter();

		private SqlParameter prmDescricaoAt = new SqlParameter();
        private SqlParameter prmValorAt = new SqlParameter();
        private SqlParameter prmCategoriaAt = new SqlParameter();
        private SqlParameter prmRecorrenteAt = new SqlParameter();
        private SqlParameter prmDataVencimentoAt = new SqlParameter();
        private SqlParameter prmDataPagamentoAt = new SqlParameter();
        private SqlParameter prmDataCadastroAt = new SqlParameter();
        private SqlParameter prmCodigoAt = new SqlParameter();

        //adaptador
        public SqlDataAdapter adaptador = new SqlDataAdapter();

        private void configuraParametros()
        {
            //parametro prmDescricao
            prmDescricao.ParameterName = "@Descricao";
            prmDescricao.SqlDbType = SqlDbType.VarChar;
            prmDescricao.Size = 40;
            prmDescricao.SourceColumn = "Descricao";
            prmDescricao.SourceVersion = DataRowVersion.Current;

            //parametro prmValor
            prmValor.ParameterName = "@Valor";
            prmValor.SqlDbType = SqlDbType.Decimal;
            prmValor.SourceColumn = "Valor";
            prmValor.SourceVersion = DataRowVersion.Current;

            //parametro prmCategoria
            prmCategoria.ParameterName = "@Categoria";
            prmCategoria.SqlDbType = SqlDbType.Int;
            prmCategoria.SourceColumn = "Categoria";
            prmCategoria.SourceVersion = DataRowVersion.Current;

            //parametro prmRecorrente
            prmRecorrente.ParameterName = "@Recorrente";
            prmRecorrente.SqlDbType = SqlDbType.TinyInt;
            prmRecorrente.SourceColumn = "Recorrente";
            prmRecorrente.SourceVersion = DataRowVersion.Current;

            //parametro prmDataVencimento
            prmDataVencimento.ParameterName = "@DataVencimento";
            prmDataVencimento.SqlDbType = SqlDbType.Date;
            prmDataVencimento.SourceColumn = "DataVencimento";
            prmDataVencimento.SourceVersion = DataRowVersion.Current;

            //parametro prmDataPagamento
            prmDataPagamento.ParameterName = "@DataPagamento";
            prmDataPagamento.SqlDbType = SqlDbType.Date;
            prmDataPagamento.SourceColumn = "DataPagamento";
            prmDataPagamento.SourceVersion = DataRowVersion.Current;

            //parametro prmDataCadastro
            prmDataCadastro.ParameterName = "@DataCadastro";
            prmDataCadastro.SqlDbType = SqlDbType.Date;
            prmDataCadastro.SourceColumn = "DataCadastro";
            prmDataCadastro.SourceVersion = DataRowVersion.Current;
            
            //parametro prmCodigo
            prmCodigo.ParameterName = "@Codigo";
            prmCodigo.SqlDbType = SqlDbType.Int;
            prmCodigo.SourceColumn = "Codigo";
            prmCodigo.SourceVersion = DataRowVersion.Original;


            prmDescricaoAt.ParameterName = "@Descricao";
            prmDescricaoAt.SqlDbType = SqlDbType.VarChar;
            prmDescricaoAt.Size = 40;
            prmDescricaoAt.SourceColumn = "Descricao";
            prmDescricaoAt.SourceVersion = DataRowVersion.Current;

            prmValorAt.ParameterName = "@Valor";
            prmValorAt.SqlDbType = SqlDbType.Decimal;
            prmValorAt.SourceColumn = "Valor";
            prmValorAt.SourceVersion = DataRowVersion.Current;

            prmCategoriaAt.ParameterName = "@Categoria";
            prmCategoriaAt.SqlDbType = SqlDbType.Int;
            prmCategoriaAt.SourceColumn = "Categoria";
            prmCategoriaAt.SourceVersion = DataRowVersion.Current;

            prmRecorrenteAt.ParameterName = "@Recorrente";
            prmRecorrenteAt.SqlDbType = SqlDbType.TinyInt;
            prmRecorrenteAt.SourceColumn = "Recorrente";
            prmRecorrenteAt.SourceVersion = DataRowVersion.Current;

            prmDataVencimento.ParameterName = "@DataVencimento";
            prmDataVencimentoAt.SqlDbType = SqlDbType.Date;
            prmDataVencimentoAt.SourceColumn = "DataVencimento";
            prmDataVencimentoAt.SourceVersion = DataRowVersion.Current;

            prmDataPagamentoAt.ParameterName = "@DataPagamento";
            prmDataPagamentoAt.SqlDbType = SqlDbType.Date;
            prmDataPagamentoAt.SourceColumn = "DataPagamento";
            prmDataPagamentoAt.SourceVersion = DataRowVersion.Current;

            prmDataCadastroAt.ParameterName = "@DataCadastro";
            prmDataCadastroAt.SqlDbType = SqlDbType.Date;
            prmDataCadastroAt.SourceColumn = "DataCadastro";
            prmDataCadastroAt.SourceVersion = DataRowVersion.Current;
            
            prmCodigoAt.ParameterName = "@Codigo";
            prmCodigoAt.SqlDbType = SqlDbType.Int;
            prmCodigoAt.SourceColumn = "Codigo";
            prmCodigoAt.SourceVersion = DataRowVersion.Original;
        }

        public AdaptadorRegistros()
        {
        }


        public AdaptadorRegistros(string conexaoString)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);

            configuraParametros();
            //Comando para a seleção de dados
            SqlCommand comandoSelecaoReg = new SqlCommand("select * from Registros order by Categoria, Descricao;", conexao);
            //Comando para a inserção de dados
            SqlCommand comandoInsercaoReg = new SqlCommand("Insert into Registros (Descricao, Valor, Categoria, Recorrente, DataVencimento, DataPagamento, DataCadastro) values (@Descricao, @Valor, @Categoria, @Recorrente, @DataVencimento, @DataPagamento, @DataCadastro)", conexao);
            comandoInsercaoReg.Parameters.Add(prmDescricao);
            comandoInsercaoReg.Parameters.Add(prmValor);
            comandoInsercaoReg.Parameters.Add(prmCategoria);
            comandoInsercaoReg.Parameters.Add(prmRecorrente);
            comandoInsercaoReg.Parameters.Add(prmDataVencimento);
            comandoInsercaoReg.Parameters.Add(prmDataPagamento);
            comandoInsercaoReg.Parameters.Add(prmDataCadastro);
            //Comando para a atualização de dados
            SqlCommand comandoAtualizacaoReg = new SqlCommand("Update Registros set Descricao = @Descricao, Valor = @Valor, Categoria = @Categoria, Status1 = @Recorrente, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento, DataCadastro = @DataCadastro = @Parcelas where Codigo = @Codigo", conexao);
            comandoAtualizacaoReg.Parameters.Add(prmDescricaoAt);
            comandoAtualizacaoReg.Parameters.Add(prmValorAt);
            comandoAtualizacaoReg.Parameters.Add(prmCategoriaAt);
            comandoAtualizacaoReg.Parameters.Add(prmRecorrenteAt);
            comandoAtualizacaoReg.Parameters.Add(prmDataVencimentoAt);
            comandoAtualizacaoReg.Parameters.Add(prmDataPagamentoAt);
            comandoAtualizacaoReg.Parameters.Add(prmDataCadastroAt);
            comandoAtualizacaoReg.Parameters.Add(prmCodigoAt);
            //Comandos para a remoção de dados
            SqlCommand comandoRemocaoReg = new SqlCommand("Delete from Registros where Codigo = @Codigo", conexao);
            comandoRemocaoReg.Parameters.Add(prmCodigo);
            
            //comandos do adaptador
            adaptador.SelectCommand = comandoSelecaoReg;
            adaptador.InsertCommand = comandoInsercaoReg;
            adaptador.UpdateCommand = comandoAtualizacaoReg;
            adaptador.DeleteCommand = comandoRemocaoReg;
        }
    }
}
