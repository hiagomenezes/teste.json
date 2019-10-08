using System;
using System.Collections.Generic;
using System.Text;

namespace TesteJson
{
    class testelista
    {
        /// <summary>
        ///     Série do RPS
        /// </summary>
        public string serieRPS { get; set; }
        /// <summary>
        /// Série do NF-e. * Obrigatório somente para contribuintes com regime especial.
        /// </summary>
        public string serieNFe { get; set; }
        /// <summary>
        /// Número do RPS, iniciar no número 1, com zeros a esquerda, sendo que
        ///obrigatoriamente os 3 primeiros dígitos sejam zero.Exemplo:
        /// 0000000001. * Obrigatório somente para RPS com situação "E", para
        /// RPS com situação "C" enviar zeros exceto para Código do Motivo de
        ///Cancelamento 03 (Substituição), neste caso informar o número do novo
        ///RPS.Observação os 3 primeiros dígitos são reservados. 
        /// </summary>
        public string numeroRPS { get; set; }
        /// <summary>
        /// Data de Emissão do RPS AAAAMMDD
        /// Hora de Emissão do RPS HHMMSS
        /// </summary>
        public DateTime dataRPS { get; set; }
        /// <summary>
        /// E para RPS Enviado / C para RPS Cancelado
        /// </summary>
        public string situacaoRPS { get; set; }
        /// <summary>
        /// 01 para Cancelamento do Serviço / 02 para Dados Incorretos / 03 para
        /// Substituição. * Obrigatório somente para os casos de RPS com Situação
        ///   "C" (cancelado).
        /// </summary>
        public string codigoMotivoCancelamento { get; set; }
        /// <summary>
        /// Número da NF-e a ser cancelada/substituida. * Obrigatório somente
        /// para os casos de RPS com Situação "C" (cancelado).
        /// </summary>
        public int numeroNFesubs { get; set; }
        /// <summary>
        /// Série da NF-e a ser cancelada/substituida. * Obrigatório somente para
        ///     os casos de RPS com Situação "C" (cancelado) e para contribuintes com
        ///regime especial.
        /// </summary>
        public string sNFeCS { get; set; }
        /// <summary>
        /// Data de emissão da NF-e a ser cancelada/substituida. * Obrigatório
        /// somente para os casos de RPS com Situação "C" (cancelado).
        /// </summary>
        public DateTime nFeCS { get; set; }
        /// <summary>
        /// Descrição do Motivo de Cancelamento. * Obrigatório somente para os
        /// casos de RPS com Situação "C" (cancelado).
        /// </summary>
        public string descricaoCancelamento { get; set; }
        /// <summary>
        /// Código da Atividade do Serviço Prestado
        /// </summary>
        public string cSP { get; set; }
        /// <summary>
        /// 1 para serviço prestado no Município / 2 para serviço prestado fora do
        ///Município. * Obrigatório para as atividades relacionadas nas exceções,
        ///conforme artigo 39 da LC 118/02.
        /// </summary>
        public string lPS { get; set; }
        /// <summary>
        /// 1 para serviço prestado em vias públicas / 2 para serviço não prestado
        ///em vias públicas. * Obrigatório para as atividades dos itens 7.02 e 7.05
        /// da lista de serviços, não prestados em vias públicas.
        /// </summary>
        public string sPVP { get; set; }
        /// <summary>
        /// Obrigatório para as atividades dos itens 7.02 e 7.05 da lista de
        /// serviços, não prestados em vias públicas.
        /// </summary>
        public string enderecoL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades dos itens 7.02 e 7.05 da lista de
        /// serviços, não prestados em vias públicas.
        /// </summary>
        public string numeroL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades dos itens 7.02 e 7.05 da lista de
        /// serviços, não prestados em vias públicas.
        /// </summary>
        public string complementoL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades dos itens 7.02 e 7.05 da lista de
        /// serviços, não prestados em vias públicas.
        /// </summary>
        public string bairroL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades relacionadas nas exceções, conforme
        /// artigo 39 da LC 118/02
        /// </summary>
        public string cidadeL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades relacionadas nas exceções, conforme
        /// artigo 39 da LC 118/02.
        /// </summary>
        public string uFL { get; set; }
        /// <summary>
        /// Obrigatório para as atividades dos intes 7.02 e 7.05 da lista de
        /// serviços, não prestados em vias públicas.
        /// </summary>
        public string cEPL { get; set; }
        /// <summary>
        /// Quantidade, somente valor inteiro.
        /// </summary>
        public string quantidadeServico { get; set; }
        /// <summary>
        /// Valor do Serviço, referente ao valor unitário, valor com 15 posições com
        /// zeros a esquerda, sem vírgula e sem ponto.Exemplo: R$10,25 =
        /// 000000000001025
        /// </summary>
        public string valorServico { get; set; }
        /// <summary>
        /// Somatória das Retenções, valor com 15 posições com zeros a esquerda,
        /// sem vírgula e sem ponto.Exemplo: R$10,25 = 000000000001025
        /// </summary>
        public string valorTRetençoes { get; set; }
        /// <summary>
        /// 1 Para Tomador Estrangeiro 2 para Tomador Brasileiro
        /// </summary>
        public string tomadorEstrangeiro { get; set; }
        /// <summary>
        /// Códido do pais de nacionalidade do tomador, conforme tabela de paises,
        /// quando o tomador for estrangeiro. * Exceto para tomadores brasileiros.
        /// </summary>
        public string pNTE { get; set; }
        /// <summary>
        /// 1 Para Serviço exportado 2 para Serviço não exportado. *Exceto para
        /// tomadores brasileiros.
        /// </summary>
        public string sPE { get; set; }
        /// <summary>
        /// 1 para CPF / 2 para CNPJ * Exceto para Tomador estrangeiro
        /// </summary>
        public string identificacaoTomador { get; set; }
        /// <summary>
        /// Número do Documento do Tomador * Exceto para Tomador estrangeiro
        /// </summary>
        public string tCNPJ { get; set; }
        /// <summary>
        /// Razão Social / Nome do Tomador
        /// </summary>
        public string razaoSocial { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string enderecoT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string numeroT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string complementoT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string bairroT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string cidadeT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string uFT { get; set; }
        /// <summary>
        /// * Exceto para Tomador estrangeiro
        /// </summary>
        public string cEPT { get; set; }
        /// <summary>
        /// e-mail do Tomador, permitido no máximo 3 e-mails, usando o caracter
        /// "|" (pipe ou barra vertical) como delimitador de e-mail. * Obrigatório
        /// somente para Tomador Pessoa Juridica
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Número da Fatura
        /// </summary>
        public int nfatura { get; set; }
        /// <summary>
        /// Somatória das Retenções, valor com 15 posições com zeros a esquerda,
        /// sem vírgula e sem ponto.Exemplo: R$10,25 = 000000000001025
        /// </summary>
        public int vfatura { get; set; }
        /// <summary>
        /// Forma de pagamento da Fatura.* Obigatório quando for informado o
        /// número da fatura.
        /// </summary>
        public string formaPagamento { get; set; }
        /// <summary>
        /// Descritivo do Serviço Prestado (Este campo será impresso em um
        /// retângulo com até 100 caracteres por linha(largura) e 13 linhas
        /// (altura). Usar o caracter "|" (pipe ou barra vertical) como delimitador de
        /// quebra de linha.A cada 100 caracteres é obrigatório o caracter de
        /// quebra "|", não deverá ser colocado esse delimitador na 13º linha
        /// (última linha).
        /// </summary>
        public string discriminacaoServico { get; set; }
        /// <summary>
        /// 3 *Obrigatório para lançamento de Retenção ou Lançamento de Valor
        /// não Incluso na Base de Cálculo de Serviço.Este registro deverá repetir
        /// para cada código conforme campo "Código de Outros Valores".
        /// </summary>
        public int tipoRegistro { get; set; }
        /// <summary>
        /// 01 - para IRRF
        /// 02 - para PIS/PASEP
        /// 03 - para COFINS
        /// 04 - para CSLL
        /// VN - para Valor não Incluso na Base de Cálculo(exceto tributos
        /// federais). Esse campo somado ao valor total dos serviços resulta no
        /// Valor total da nota.
        /// </summary>
        public string codOutVal { get; set; }
        /// <summary>
        /// Somatória das Retenções, valor com 15 posições com zeros a esquerda,
        /// sem vírgula e sem ponto.Exemplo: R$10,25 = 000000000001025
        /// </summary>
        public string valor { get; set; }
        /// <summary>
        /// Valor Total dos Serviços contidos no Arquivo (Soma dos valores
        /// unitários dos serviços multiplicados pelas quantidades de cada serviço)
        /// </summary>
        public int valToSer { get; set; }
        /// <summary>
        /// Valor Total das Retenções e outros valores informados no registro 3
        /// </summary>
        public int valToValReg { get; set; }
        /// <summary>
        /// 01 para Cancelamento do Serviço / 02 para Dados Incorretos / 03 para
        /// Substituição. * Obrigatório somente para os casos de RPS com Situação
        /// "C" (cancelado).
        /// </summary>
        public string codMovCancelamento { get; set; }

        public testelista(string serieRPS, string serieNFe, string numeroRPS, DateTime dataRPS, string situacaoRPS, string codigoMotivoCancelamento, int numeroNFesubs, string sNFeCS, DateTime nFeCS, string descricaoCancelamento, string cSP, string lPS, string sPVP, string enderecoL, string numeroL, string complementoL, string bairroL, string cidadeL, string uFL, string cEPL, string quantidadeServico, string valorServico, string valorTRetençoes, string tomadorEstrangeiro, string pNTE, string sPE, string identificacaoTomador, string tCNPJ, string razaoSocial, string enderecoT, string numeroT, string complementoT, string bairroT, string cidadeT, string uFT, string cEPT, string email, int nfatura, int vfatura, string formaPagamento, string discriminacaoServico, int tipoRegistro, string codOutVal, string valor, int valToSer, int valToValReg, string codMovCancelamento)
        {
            this.serieRPS = serieRPS;
            this.serieNFe = serieNFe;
            this.numeroRPS = numeroRPS;
            this.dataRPS = dataRPS;
            this.situacaoRPS = situacaoRPS;
            this.codigoMotivoCancelamento = codigoMotivoCancelamento;
            this.numeroNFesubs = numeroNFesubs;
            this.sNFeCS = sNFeCS;
            this.nFeCS = nFeCS;
            this.descricaoCancelamento = descricaoCancelamento;
            this.cSP = cSP;
            this.lPS = lPS;
            this.sPVP = sPVP;
            this.enderecoL = enderecoL;
            this.numeroL = numeroL;
            this.complementoL = complementoL;
            this.bairroL = bairroL;
            this.cidadeL = cidadeL;
            this.uFL = uFL;
            this.cEPL = cEPL;
            this.quantidadeServico = quantidadeServico;
            this.valorServico = valorServico;
            this.valorTRetençoes = valorTRetençoes;
            this.tomadorEstrangeiro = tomadorEstrangeiro;
            this.pNTE = pNTE;
            this.sPE = sPE;
            this.identificacaoTomador = identificacaoTomador;
            this.tCNPJ = tCNPJ;
            this.razaoSocial = razaoSocial;
            this.enderecoT = enderecoT;
            this.numeroT = numeroT;
            this.complementoT = complementoT;
            this.bairroT = bairroT;
            this.cidadeT = cidadeT;
            this.uFT = uFT;
            this.cEPT = cEPT;
            this.email = email;
            this.nfatura = nfatura;
            this.vfatura = vfatura;
            this.formaPagamento = formaPagamento;
            this.discriminacaoServico = discriminacaoServico;
            this.tipoRegistro = tipoRegistro;
            this.codOutVal = codOutVal;
            this.valor = valor;
            this.valToSer = valToSer;
            this.valToValReg = valToValReg;
            this.codMovCancelamento = codMovCancelamento;
        }

    }
}
