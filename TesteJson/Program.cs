using System;
using System.IO;
using Newtonsoft;
using System.Collections.Generic;
using System.Globalization;

public class RPS
{
    public int id_dado { get; set; }
    public int id_ies { get; set; }
    public string nome_ies { get; set; }
    public int id_filial { get; set; }
    public string cod_filial { get; set; }
    public string nome_filial { get; set; }
    public int id_tipo_vinculo { get; set; }
    public string descricao_tipo_vinculo { get; set; }
    public object id_estado_civil { get; set; }
    public object id_nacionalidade { get; set; }
    public object id_tipo_documento { get; set; }
    public object id_meio_transporte { get; set; }
    public object id_raca { get; set; }
    public int id_status_dados { get; set; }
    public string descricao_status_dados { get; set; }
    public string matricula { get; set; }
    public string nome { get; set; }
    public string nome_resumido { get; set; }
    public object nome_mae { get; set; }
    public string cpf_numero { get; set; }
    public object flag_cpf_titular { get; set; }
    public string documento_numero { get; set; }
    public object documento_data_emissao { get; set; }
    public object documento_orgao_expeditor { get; set; }
    public object documento_uf { get; set; }
    public DateTime data_nascimento { get; set; }
    public string email { get; set; }
    public string cod_barras { get; set; }
    public object renda_mensal { get; set; }
    public object numero_conta_corrente { get; set; }
    public object ano_em_curso { get; set; }
    public string data_termino_curso { get; set; }
    public string curso { get; set; }
    public object ano_conclusao_ensino_medio { get; set; }
    public string sexo { get; set; }
    public string campo_4 { get; set; }
    public object numero_dependentes { get; set; }
    public DateTime data_registro { get; set; }
    public string alterado_por { get; set; }
    public object percentual_preenchimento { get; set; }
    public object flag_sincronizado { get; set; }
    public DateTime data_atualizacao { get; set; }
    public int id_usuario_atualizacao { get; set; }
    public object data_inicio_curso { get; set; }
    public object is_autoriza_contato { get; set; }
    public string imagem_dado { get; set; }
    public string imagem_ies { get; set; }
    public string imagem_qrcode_foto { get; set; }
    public string imagem_qrcode_acesso { get; set; }
    public Telefone telefone { get; set; }
    public Complemento complemento { get; set; }
    public object endereco { get; set; }
    public object cartao { get; set; }
    public Foto foto { get; set; }
    public Parametro parametro { get; set; }
    public Movimentacao movimentacao { get; set; }
    public Statuspedido[] statusPedido { get; set; }
}

public class Telefone
{
    public int id_dado_telefone { get; set; }
    public int id_dados { get; set; }
    public int id_tipo_telefone { get; set; }
    public string ddd { get; set; }
    public string numero { get; set; }
    public object ramal { get; set; }
}

public class Complemento
{
    public int id_dado_complemento { get; set; }
    public int id_dado { get; set; }
    public object nome_social { get; set; }
    public object nome_filial { get; set; }
    public object periodo { get; set; }
    public object cod_barras_2 { get; set; }
    public object id_tipo_cartao { get; set; }
    public object flag_correntista { get; set; }
    public object data_registro { get; set; }
    public object pagarme_customer_id { get; set; }
}

public class Foto
{
    public int id_dado_foto { get; set; }
    public int id_dado { get; set; }
    public int id_status_foto { get; set; }
    public object id_motivo_rejeicao { get; set; }
    public DateTime data_upload { get; set; }
    public DateTime data_download { get; set; }
    public object flag_foto_branca { get; set; }
    public DateTime data_tratamento { get; set; }
    public DateTime data_benft { get; set; }
    public object descricao_motivo_rejeicao { get; set; }
}

public class Parametro
{
    public bool is_primeira_solicitacao { get; set; }
    public bool solicita_isic { get; set; }
    public string carteirinha_cor_fundo { get; set; }
    public string carteirinha_cor_logo { get; set; }
    public string carteirinha_cor_fonte { get; set; }
    public object carteirinha_logo_filial { get; set; }
    public bool is_acessa_foto { get; set; }
    public bool is_acessa_dado { get; set; }
}

public class Movimentacao
{
    public int id_movimentacao { get; set; }
    public int id_dado { get; set; }
    public object id_movimentacao_tipo { get; set; }
    public object id_lote { get; set; }
    public int id_dado_historico { get; set; }
    public int id_status_movimentacao { get; set; }
    public object id_nsp { get; set; }
    public object retorno { get; set; }
    public DateTime data_solicitacao { get; set; }
    public object data_producao { get; set; }
    public string tipo_funcao_movimento { get; set; }
    public bool flag_emissao { get; set; }
    public object data_entrega_individual { get; set; }
    public object id_usuario_entrega_individual { get; set; }
    public int numero_sequencial_solicitacao { get; set; }
    public object qr_code { get; set; }
    public object id_dado_complemento_historico { get; set; }
    public int id_tipo_cartao { get; set; }
    public object credencial { get; set; }
}

public class Statuspedido
{
    public int status { get; set; }
    public string mensagem { get; set; }
    public DateTime data { get; set; }
}


namespace TesteJson
{
    class Program
    {
        static void Main(string[] args)
        {
            ///RPS teste = new RPS();
            // esta linha é para pegar o caminho do json e ler linha por linha.
           string fileJsonString =  File.ReadAllText(@"C:\temp\input\return-api.json");
            // 
            RPS teste = Newtonsoft.Json.JsonConvert.DeserializeObject<RPS>(fileJsonString);
            Telefone teste2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Telefone>(fileJsonString);
            //Console.WriteLine(fileJsonString);

            // o caminho destinho para a onde o arquivo vai depois de formatado
            string output = string.Format(@"C:\temp\output\.txt", DateTime.Now);

            using (StreamWriter pastadestino = new StreamWriter(fileJsonString))
            {
                pastadestino.WriteLine(fileJsonString);
                pastadestino.WriteLine(teste.documento_orgao_expeditor + teste2.numero);
                //pastadestino.WriteLine();

                pastadestino.Flush();
                pastadestino.Close();
            }
            Statuspedido kleber = new Statuspedido();
            kleber.mensagem = "";

            List<string> jsonlist = new List<string>();
           
            
            



        }

        //public int id_dado { get; set; }
        //public int id_ies { get; set; }
        //public string nome_ies { get; set; }
        //public string nome { get; set; }
        //public string nome_mae { get; set; }

    }
}
