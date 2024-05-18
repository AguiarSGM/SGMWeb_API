namespace PortalBusiness.Infrastructure.Data.Queries;

public static class SqlQueries
{
    public static string User => @"
        SELECT USU.ID, USU.NOMEUSUARIO, USU.LOGINUSUARIO, USU.SENHAUSUARIO, 
               USU.CODIGORCAUSUARIO, USU.IDSUPERIOR, USU.SITUACAOUSUARIO, 
               USU.IDPERFILUSUARIO, PER.NOMEPERFILUSUARIO, PER.SIGLAPERFILUSUARIO 
        FROM TABUSUARIO USU 
        LEFT JOIN TABPERFILUSUARIO PER ON PER.ID = USU.IDPERFILUSUARIO 
        WHERE USU.LOGINUSUARIO = @LOGINUSUARIO";

    public static string Sales => @"
        SELECT  DATAPEDIDO,
				FILIAL,
				IDUSUARIO,
				CODIGOPEDIDORCA,
				CODIGOCLIENTE,
				RAZAOSOCIALCLIENTE,
				FANTASIACLIENTE,
				TIPOVENDA,
				DESCRICAOTIPOVENDA,
				STATUS,
				CODIGOCOBRANCAPEDIDO,
				CODIGOPLANOPAGAMENTOPEDIDO,
				SITUACAOPEDIDOERP,
				NUMEROPEDIDOERP,
				VALORTOTALPEDIDO,
				RETORNO,
				DATAENTREGAPEDIDO
			FROM VSGM_PEDIDO_RESUMIDO P 
			WHERE P.IDUSUARIO = @IDUSUARIO
			ORDER BY DATAPEDIDO DESC";

    public static string SalesItens => @"
        SELECT * FROM (
            SELECT 
                P.IDUSUARIO, 
                P.CODIGOPEDIDORCA, 
                I.ITEM, 
                i.codigoproduto, 
                i.descricaoproduto, 
                i.unidadevenda, 
                i.quantidade, 
                0 Quantidadeatendida, 
                i.quantidade - i.quantidadefaturada AS qtdcorte, 
                i.precovendadesconto 
            FROM 
                tabpedido p, 
                tabpedidoitens i 
            WHERE 
                p.codigopedidorca = i.codigopedidorca 
                AND p.codigorca = i.codigorca 
                AND p.statusprocessamento = 'AB' 
            UNION 
            SELECT 
                P.IDUSUARIO, 
                P.CODIGOPEDIDORCA, 
                I.ITEM, 
                i.codigoproduto, 
                i.descricaoproduto, 
                i.unidadevenda, 
                i.quantidade, 
                m.qt_faturada Quantidadeatendida, 
                i.quantidade - m.qt_faturada AS qtdcorte, 
                i.precovendadesconto 
            FROM 
                tabpedido p, 
                tabpedidoitens i, 
                pcpedcfv f, 
                pcpedifv m 
            WHERE 
                p.codigopedidorca = i.codigopedidorca 
                AND p.codigopedidorca = m.numpedrca 
                AND p.codigorca = m.codusur 
                AND p.cnpjcpfcliente = m.cgccli 
                AND f.numpedrca = m.numpedrca 
                AND f.codusur = m.codusur 
                AND i.codigoproduto = m.codprod 
                AND p.statusprocessamento = 'P'
        )
        WHERE IDUSUARIO = @IDUSUARIO AND CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string SalesFull => @"
        SELECT 
            CODIGOPEDIDORCA, 
            CODIGOPEDIDO, 
            CODIGORCA, 
            NOMERCA, 
            CODIGOCLIENTE, 
            FANTASIACLIENTE, 
            RAZAOSOCIALCLIENTE, 
            CNPJCPFCLIENTE, 
            DATAHORAABERTURAPEDIDO, 
            DATAHORAFECHAMENTOPEDIDO, 
            NUMEROPEDIDOCLIENTE, 
            DATAENTREGAPEDIDO, 
            CODIGOUNIDADEPEDIDO, 
            CODIGOUNIDADENFPEDIDO, 
            CODIGOUNIDADERETIRADAPEDIDO, 
            VALORFRETEPEDIDO, 
            CODIGOCOBRANCAPEDIDO, 
            CODIGOPLANOPAGAMENTOPEDIDO, 
            CONDICAOVENDAPEDIDO, 
            OBSERVACAOPEDIDO, 
            OBSERVACAOENTREGAPEDIDO, 
            FRETEDESPACHOPEDIDO, 
            FRETEREDESPACHOPEDIDO, 
            CODIGOFORNECEDORFRETEPEDIDO, 
            PRAZO1PEDIDO, 
            PRAZO2PEDIDO, 
            PRAZO3PEDIDO, 
            PRAZO4PEDIDO, 
            PRAZO5PEDIDO, 
            PRAZO6PEDIDO, 
            PRAZO7PEDIDO, 
            PRAZO8PEDIDO, 
            PRAZO9PEDIDO, 
            PRAZO10PEDIDO, 
            PRAZO11PEDIDO, 
            PRAZO12PEDIDO, 
            ORIGEMPEDIDO, 
            NUMEROPEDIDOCOMPRADOR, 
            POSICAOATUALPEDIDO, 
            SALDOATUALRCA, 
            TIPOPRIORIDADEENTREGAPEDIDO, 
            PERCDESCABATIMENTOPEDIDO, 
            CUSTOBONIFICACAOPEDIDO, 
            CODFORNECBONIFICACAOPEDIDO, 
            CODIGOBONIFICACAOPEDIDO, 
            AGRUPAMENTOPEDIDO, 
            CODIGOENDERECOENTREGAPEDIDO, 
            ORCAMENTOPEDIDO, 
            VALORDESCONTOABATIMENTOPEDIDO, 
            VALORENTRADAPEDIDO, 
            STATUSPEDIDO, 
            TOTALITENSPEDIDO, 
            TOTALPEDIDO, 
            TOTALPEDIDOCOMIMPOSTO, 
            OBSERVACAORETORNO, 
            SALDOVERBA, 
            QUEBRAPEDIDOFRETE, 
            PERCENTUALFRETEOUTRAFILIAL, 
            CODIGOFILIALPEDIDOFRETE, 
            CODIGOPRODUTOPEDIDOFRETE, 
            PRECOPRODUTOPEDIDOFRETE, 
            CODIGOPEDIDORCAPEDIDOFRETE, 
            CIDADECLIENTE, 
            TIPOEMISSAO, 
            QUEBRAPEDIDOPREVENDA, 
            CODIGOPEDIDORCAPEDIDOPREVENDA, 
            CODIGOFILIALPEDIDOPREVENDA, 
            RETORNONUMEROPEDIDOERP, 
            RETORNOMOTIVOBLOQUEIO, 
            RETORNOVALORPEDIDO, 
            RETORNOVALORATENDIDO, 
            NUMEROPEDIDOVENDA, 
            DATAEMISSAOMAPA, 
            NUMEROPEDIDOERPORIGINAL, 
            COMISSAO, 
            PESO, 
            GEROUBRINDE, 
            CODIGOMOTORISTA, 
            NOMEMOTORISTA, 
            CELULARMOTORISTA, 
            DATACADASTRO, 
            STATUSPROCESSAMENTO, 
            DATAPROCESSAMENTO, 
            MENSAGEMPROCESSAMENTO, 
            NOMEARQUIVOREMESSA, 
            IDUSUARIO, 
            ENDERECOCLIENTE 
        FROM 
            TABPEDIDO P 
        WHERE 
            P.CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string SalesItensFull => @"
         SELECT 
                CODIGOPEDIDORCA, 
                CODIGORCA, 
                DATAHORAABERTURAPEDIDO, 
                ITEM, 
                I.CODIGOPRODUTO, 
                I.DESCRICAOPRODUTO, 
                QUANTIDADE, 
                PRECOVENDAORIGINAL, 
                PRECOVENDA, 
                CODIGOBARRAS, 
                QUANTIDADEFATURADA, 
                BONIFICACAO, 
                CODIGOCOMBO, 
                CORTE, 
                PERCENTUALDESCONTO, 
                PERCENTUALDESCONTOBOLETO, 
                SUGESTAO, 
                CODIGOPEDIDO, 
                PRECOVENDADESCONTO, 
                VALORTOTAL, 
                VALORTOTALCOMIMPOSTO, 
                CODIGODESCONTO3306, 
                DESCRICAODESCONTO3306, 
                CODIGOPRODUTOPRINCIPAL, 
                OBSERVACAORETORNO, 
                CODIGOUNIDADERETIRA, 
                TIPOENTREGA, 
                CODIGODESCONTO561, 
                DIFERENCAPRECO, 
                SALDOVERBA, 
                BASECREDDEBRCADESCONTO561, 
                APLICAAUTOMATICODESCONTO561, 
                PERCENTUALDESCONTO561, 
                CODIGOAUXILIAREMBALAGEM, 
                QUANTIDADEUNITARIAEMBALAGEM, 
                UTILIZAVENDAPOREMBALAGEM, 
                TIPOCARGAPRODUTO, 
                EXIBECOMBOEMBALAGEM, 
                ITEMNEGOCIADO, 
                I.UNIDADEVENDA, 
                TIPOESTOQUEPRODUTO, 
                CODIGOREGIAO, 
                PERCENTUALACRESCIMO, 
                COMISSAO, 
                PESO, 
                VALORST, 
                PRECOCOMST, 
                VALORTOTALCOMST, 
                NUMEROCARREGAMENTO, 
                PERCENTUALBASERED, 
                PERCENTUALICM, 
                DATAVALIDADECAMPANHASHELF, 
                PRECOCAMPANHASHELF, 
                CODIGOCAMPANHASHELF, 
                UNIDADEFRIOS,
                IMGPRODUTO as IMGPRODUTO 
            FROM 
                TABPEDIDOITENS I, VSGM_PRODUTO_LISTA M
            WHERE 
                I.CODIGOPRODUTO = M.CODIGOPRODUTO
               AND
                I.UNIDADEVENDA = M.UNIDADEVENDA 
               AND  
                I.CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string Client => @"
        SELECT DISTINCT 
            C.CODIGOCLIENTE, 
            C.RAZAOSOCIALCLIENTE, 
            C.FANTASIACLIENTE, 
            C.TELEFONECOMERCIAL, 
            C.CNPJCLIENTE, 
            C.INSCRICAOESTADUALCLIENTE, 
            C.INSCRICAOMUNICIPALCLIENTE, 
            C.CODIGOCNAECLIENTE, 
            C.CODIGOATIVIDADECLIENTE,
            C.CONTRIBUINTE, 
            C.SIMPLESNACIONALCLIENTE, 
            C.TIPOPESSOACLIENTE, 
            C.EMAILCLIENTE, 
            C.EMAILNFECLIENTE, 
            C.CODIGOCOBRANCACLIENTE, 
            C.CODIGOPLANOPAGAMENTOCLIENTE, 
            C.LIMITECREDITOCLIENTE AS LIMITECREDITOCLIENTE, 
            sgmcontrol.SGM_BUSCARLIMCREDCLI(C.CODIGOCLIENTE, NULL, 'D', 'S') AS SALDOLIMITECLIENTE, 
            C.DATAVENCIMENTOLIMITECLIENTE, 
            (select sum(m.valor) 
                from pccrecli m 
                where m.Dtdesconto is null 
                and dtestorno is null and m.codcli = c.CODIGOCLIENTE) AS CREDITOPENDENTECLIENTE,
            (select sum(p.valor) 
                from pcprest p 
                where p.codcli = c.CODIGOCLIENTE 
                and p.dtpag is null) AS DEBITOCLIENTE, 
            C.BLOQUEIOCLIENTE, 
            C.DATABLOQUEIOCLIENTE,
            C.MONITORADOCLIENTE, 
            C.CODIGOPRACACLIENTE, 
            C.NOMEPRACACLIENTE, 
            C.REGIAOCLIENTE, 
            C.DATAULTIMACOMPRACLIENTE, 
            C.VIPCLIENTE, 
            C.CLASSEVENDACLIENTE, 
            C.CODIGOREDECLIENTE, 
            C.OBSERVACAOGERENCIAL1CLIENTE, 
            C.OBSERVACAOENTREGACLIENTE, 
            C.ENDERECOCOMERCIALCLIENTE, 
            C.BAIRROCOMERCIALCLIENTE, 
            C.CIDADECOMERCIALCLIENTE, 
            C.UFCOMERCIALCLIENTE, 
            C.NUMEROENDERECOCOMERCIALCLIENTE, 
            C.CEPCOMERCIALCLIENTE, 
            C.ENDERECOENTREGACLIENTE, 
            C.BAIRROENTREGACLIENTE, 
            C.CIDADEENTREGACLIENTE, 
            C.UFENTREGACLIENTE, 
            C.NUMEROENTREGACLIENTE, 
            C.CEPENTREGACLIENTE, 
            C.TELEFONEENTREGACLIENTE, 
            C.ENDERECOCOBRANCACLIENTE, 
            C.BAIRROCOBRANCACLIENTE, 
            C.CIDADECOBRANCACLIENTE, 
            C.UFCOBRANCACLIENTE, 
            C.NUMEROCOBRANCACLIENTE, 
            C.CEPCOBRANCACLIENTE, 
            C.TELEFONECOBRANCACLIENTE, 
            C.CODIGORCA1CLIENTE, 
            C.ALVARACLIENTE, 
            C.DATAVENCIMENTOALVARACLIENTE, 
            C.OBSERVACAO1CLIENTE, 
            C.OBSERVACAO2CLIENTE, 
            C.PERCENTUALDESCONTO1CLIENTE, 
            C.PERCENTUALDESCONTO2CLIENTE, 
            C.CODIGORCA2CLIENTE, 
            C.CODIGOPRINCIPALCLIENTE, 
            C.CONSUMIDORFINALCLIENTE, 
            C.TIPOEMPRESACLIENTE, 
            C.OBSERVACAOGERENCIAL2CLIENTE, 
            C.OBSERVACAOGERENCIAL3CLIENTE, 
            C.PRAZOMEDIOCLIENTE, 
            C.BLOQUEADOSEFAZCLIENTE, 
            C.CODIGOCIDADECLIENTE, 
            C.USADEBCREDRCA, 
            C.USADESCONTOICMS, 
            C.DESCPRODUTO, 
            C.FRETEDESPACHO, 
            C.PLPAGNEG, 
            C.EMITEDUP, 
            C.PERDESC, 
            C.PERDESC2, 
            C.CONDVENDA1, 
            C.CONDVENDA5, 
            C.CONDVENDA7, 
            C.CONDVENDA10, 
            C.CONDVENDA99, 
            C.CONDVENDA14, 
            C.PRAZOADICIONAL, 
            C.PERBASEVEND, 
            C.PERCOMCLI, 
            C.CALCULAST, 
            C.CLIENTEFONTEST, 
            C.ISENTOICMS, 
            C.UTILIZAIESIMPLIFICADA, 
            C.ISENTOIPI, 
            C.CODFILIALNF, 
            C.ACEITAVENDAFRACAO, 
            C.VALIDAMAXVENDAPF, 
            C.VALIDARMULTIPLOVENDA, 
            C.VALIDARCAMPANHABRINDE, 
            C.ACEITATROCANEGATIVA, 
            C.PERDESCISENTOICMS, 
            C.TIPODESCISENCAO, 
            C.USAIVAFONTEDIFERENCIADO, 
            C.IVAFONTE, 
            C.ATUALIZASALDOCCDESCFIN, 
            C.AGREGARVALORDESCFIN, 
            C.ORIGEMPRECO, 
            C.REPASSE, 
            C.UTILIZACALCULOSTMT, 
            C.TV10USACUSTOPRODUTO, 
            C.VALIDARLIMBONIFIC, 
            C.CATEGORIAFIDELIDADECLIENTE, 
            C.CATEGORIACONEXAOCLIENTE, 
            C.QTDPASSAGEIROCONEXAO, 
            U.DATAULTIMACOMPRARCACLIENTE, 
            C.CODIGOGRUPOCLIENTE, 
            C.PERCENTUALTABELAESPECIAL, 
            C.TIPOPRECOTRANSFERENCIA, 
            C.USATABELAESPECIAL, 
            C.PERMITESELECAOVALIDADE 
        FROM 
            VSGM_CLIENTE C, VSGM_CLIENTE_RCA U 
        WHERE 
            C.CODIGOCLIENTE = U.CODIGOCLIENTE 
            AND C.CODIGOCLIENTE = @CODIGOCLIENTE";

    public static string Clients => @"
        SELECT DISTINCT 
            cli.codcli AS codigoCliente, 
            cli.cliente AS razaoSocialCliente, 
            cli.fantasia AS fantasiaCliente, 
            cli.cgcent AS CNPJCliente, 
            0 AS saldoLimite, 
            0 AS debito, 
            cli.bloqueio AS bloqueioCliente, 
            cli.bloqueiosefaz AS bloqueioSefaz,
            cli.estempr as client_uf,
            cli.municempr as client_cidade,
            cli.bairrocom as client_bairro,
            cli.bloqueiodefinitivo as bloqueio_definitivo
        FROM pcclient cli 
        WHERE 1 = 1 
            AND EXISTS ( 
                SELECT * 
                FROM VSGM_CLIENTE_RCA R 
                WHERE R.CODIGOCLIENTE = Cli.Codcli 
                AND R.IDUSUARIO = @IDUSUARIO) 
        ORDER BY cli.cliente ASC";

    public static string ClientesNew => @"
            SELECT ID
                   ,CPFCNPJ
                   ,IE
                   ,CONTRIBUINTE
                   ,RAZAOSOCIAL
                   ,NOMEFANTASIA
                   ,CEP
                   ,CIDADE
                   ,ENDERECO
                   ,NUMERO
                   ,UF
                   ,STATUS
              FROM TABCLIENTE";

    public static string HistoricoCobranca => @"
            SELECT DATA, 
			 TELCOB, 
			 CONTATO,
               DTPROXCONTATO, 
               OBS1, 
               OBS2
        FROM PCHISTCOB
        WHERE CODCLI = @CODIGOCLIENTE
        ORDER BY CODCLI, DATA DESC, TIPOCONTATO";

    public static string ClientesSac => @"
            SELECT M.DTAB                           AS DATAABERTURA,
                   (M.CODFUNCAB || ' - ' || E.NOME) AS ATENDENTE,
                   M.NUMMANIF                       AS PROTOCOLO,
                   (M.CODASSUNTO || ' - ' || A.ASSUNTO) ASSUNTO,
                   M.MANIFESTACAO       AS DESCRICAO,
                   M.SITUACAO,
                   TO_CLOB(M.PROVIDENCIA) || ' \ ' || TO_CLOB(M.SOLUCAO) PROVIDENCIA
              FROM PCMANIF M, PCMANASSUNTO A, PCEMPR E
             WHERE M.CODASSUNTO = A.CODASSUNTO
               AND E.MATRICULA = M.CODFUNCAB
               AND M.CODCLI = @CODIGOCLIENTE";

    public static string ClientesByIdNew => @"
            SELECT ID
                   ,CPFCNPJ
                   ,IE
                   ,CONTRIBUINTE
                   ,RAZAOSOCIAL
                   ,NOMEFANTASIA
                   ,CEP
                   ,CIDADE
                   ,ENDERECO
                   ,NUMERO
                   ,UF
                   ,STATUS
              FROM TABCLIENTE 
             WHERE ID = @ID";

    public static string ClientesNewInsert => @"
        INSERT INTO TABCLIENTE (CPFCNPJ ,IE ,CONTRIBUINTE ,RAZAOSOCIAL ,NOMEFANTASIA ,CEP ,CIDADE ,ENDERECO ,NUMERO ,UF ,STATUS)
           VALUES ('@CPFCNPJ' ,'@IE' ,'@CONTRIBUINTE' ,'@RAZAOSOCIAL' ,'@NOMEFANTASIA' ,'@CEP' ,'@CIDADE' ,'@ENDERECO' ,'@NUMERO' ,'@UF' ,'@STATUS')";

    public static string ClientesNewUpdate => @"
        UPDATE TABCLIENTE 
           SET CPFCNPJ = @CPFCNPJ
               ,IE = @IE
               ,CONTRIBUINTE = @CONTRIBUINTE
               ,RAZAOSOCIAL = @RAZAOSOCIAL
               ,NOMEFANTASIA = @NOMEFANTASIA
               ,CEP = @CEP
               ,CIDADE = @CIDADE
               ,ENDERECO = @ENDERECO
               ,NUMERO = @NUMERO
               ,UF = @UF
               ,STATUS = @STATUS
         WHERE ID = @ID
    ";

    public static string ClientesNewDelete => @"
        DELETE FROM TABCLIENTE WHERE ID = @ID
    ";

    public static string Contato => @"
            select ID
                  ,CLIENTE_ID
                  ,NOMECONTATO
                  ,CELULARCONTATO
                  ,FIXOCONTATO
                  ,EMAILCONTATO
                  ,TIPO
                  ,STATUS 
              from TABCONTATO";

    public static string ContatoByIdCliente => @"
            select ID
                  ,CLIENTE_ID
                  ,NOMECONTATO
                  ,CELULARCONTATO
                  ,FIXOCONTATO
                  ,EMAILCONTATO
                  ,TIPO
                  ,STATUS 
              from TABCONTATO
             WHERE CLIENTE_ID = @CLIENTE_ID ";

    public static string ContatoInsert => @"
        INSERT INTO TABCONTATO (CLIENTE_ID,NOMECONTATO,CELULARCONTATO,FIXOCONTATO,EMAILCONTATO,TIPO,STATUS) VALUES
					           (@CLIENTE_ID,@NOMECONTATO,@CELULARCONTATO,@FIXOCONTATO,@EMAILCONTATO,@TIPO,@STATUS) 	
    ";

    public static string ContatoUpdate => @"
        UPDATE TABCONTATO
           SET CLIENTE_ID = @CLIENTE_ID
	          ,NOMECONTATO = @NOMECONTATO
	          ,CELULARCONTATO = @CELULARCONTATO
	          ,FIXOCONTATO = @FIXOCONTATO
	          ,EMAILCONTATO = @EMAILCONTATO
	          ,TIPO = @TIPO
	          ,STATUS = @STATUS
         WHERE ID = @ID	 
    ";

    public static string ContatoDelete => @"
        DELETE FROM TABCONTATO WHERE ID = @ID
    ";

    public static string Params(bool hasParamName)
    {
        if (hasParamName)
        {
            return @"
                SELECT P.NOMEPARAMETRO, P.VALORPARAMETRO 
                FROM VSGM_PARAMETROS P 
                WHERE P.CODIGOUNIDADE = @CODIGOUNIDADE 
                AND P.NOMEPARAMETRO = '@NOMEPARAMETRO'";
        }
        else
        {
            return @"
                SELECT P.NOMEPARAMETRO, P.VALORPARAMETRO 
                FROM VSGM_PARAMETROS P 
                WHERE P.CODIGOUNIDADE = @CODIGOUNIDADE";
        }
    }

    public static string FindUserName()
    {
        return @"
        SELECT USU.ID as ID, USU.NOMEUSUARIO as Name, USU.LOGINUSUARIO as Login, USU.SENHAUSUARIO as Password, 
               USU.CODIGORCAUSUARIO as UserCode, USU.IDSUPERIOR as SuperID, USU.SITUACAOUSUARIO as UserSituation, 
               USU.IDPERFILUSUARIO as ProfileID, PER.NOMEPERFILUSUARIO as ProfileName, PER.SIGLAPERFILUSUARIO  as ProfileTag,
               USU.CODIGORCAUSUARIO as codRCA, PermiteCriarObjetivo
        FROM TABUSUARIO USU 
        LEFT JOIN TABPERFILUSUARIO PER ON PER.ID = USU.IDPERFILUSUARIO 
        WHERE UPPER(USU.LOGINUSUARIO) = UPPER('@NOMEUSUARIO')
          AND UPPER(USU.SENHAUSUARIO) = UPPER('@PASSWORD')";
        
    }

    public static string Address => @"
            SELECT CODIGOENDERECO, 
                    ENDERECOENTREGACLIENTE, 
                    NUMEROENTREGACLIENTE, 
                    BAIRROENTREGACLIENTE, 
                    CIDADEENTREGACLIENTE  
                    UFENTREGACLIENTE,   
                    CEPENTREGACLIENTE,  
                    TELEFONEENTREGACLIENTE,   
                    OBSERVACAOENTREGACLIENTE
            FROM (
                SELECT 0 AS CODIGOENDERECO, CLI.ENDERECOENTREGACLIENTE, CLI.NUMEROENTREGACLIENTE, 
                CLI.BAIRROENTREGACLIENTE, CLI.CIDADEENTREGACLIENTE, CLI.UFENTREGACLIENTE, 
                CLI.CEPENTREGACLIENTE, CLI.TELEFONEENTREGACLIENTE, CLI.OBSERVACAOENTREGACLIENTE 
                FROM VSGM_CLIENTE CLI 
                WHERE CLI.CODIGOCLIENTE = @CODIGOCLIENTE 
                UNION ALL 
                SELECT CLIEND.CODIGOENDERECO, CLIEND.ENDERECO, CLIEND.NUMERO, CLIEND.BAIRRO, 
                CLIEND.CIDADE, CLIEND.UF, CLIEND.CEP, CLIEND.TELEFONE, CLIEND.OBSERVACAO 
                FROM VSGM_CLIENTE_ENDERECO CLIEND 
                WHERE CLIEND.CODIGOCLIENTE = @CODIGOCLIENTE)";

    public static string Bills(string consult)
    {
        switch (consult)
        {
            case "A":
                return @"SELECT cob.CODIGOCOBRANCA, cob.NOMECOBRANCA, cob.NIVELVENDACOBRANCA, cob.ACEITACARTAOCOBRANCA, cob.ACEITABOLETOCOBRANCA, cob.VALORMINIMOCOBRANCA, cob.CODIGOUNIDADE
                        FROM vsgm_cobranca cob, vsgm_cliente_cobranca clico 
                        WHERE cliCo.codigoCobranca = cob.codigoCobranca 
                        AND cliCo.codigoCliente = @CODIGOCLIENTE 
                        ORDER BY cob.nomeCobranca ASC";

            case "B":
                return @"SELECT COB.CODIGOCOBRANCA, COB.NOMECOBRANCA, COB.NIVELVENDACOBRANCA, COB.ACEITACARTAOCOBRANCA, COB.ACEITABOLETOCOBRANCA, COB.VALORMINIMOCOBRANCA, COB.CODIGOUNIDADE
                        FROM VSGM_COBRANCA COB 
                        WHERE NVL(COB.NIVELVENDACOBRANCA, 0) >= (SELECT NVL(COBB.NIVELVENDACOBRANCA, 0) 
                        FROM VSGM_COBRANCA COBB 
                        WHERE COBB.CODIGOCOBRANCA = (SELECT CLI.CODIGOCOBRANCACLIENTE 
                                                    FROM VSGM_CLIENTE CLI 
                                                    WHERE CLI.CODIGOCLIENTE = @CODIGOCLIENTE)) 
                        AND NOT EXISTS (SELECT RVE.CODIGORESTRICAO 
                                        FROM VSGM_RESTRICAO_VENDA RVE 
                                        WHERE RVE.CODIGOCOBRANCA = COB.CODIGOCOBRANCA 
                                        AND (RVE.CODIGOCLIENTE = @CODIGOCLIENTE OR RVE.CODIGOUSUARIO = @CODIGORCA)) 
                        ORDER BY COB.NOMECOBRANCA ASC";

            case "C":
                return @"SELECT COB.CODIGOCOBRANCA, COB.NOMECOBRANCA, COB.NIVELVENDACOBRANCA, COB.ACEITACARTAOCOBRANCA, COB.ACEITABOLETOCOBRANCA, COB.VALORMINIMOCOBRANCA, COB.CODIGOUNIDADE
                        FROM VSGM_COBRANCA COB 
                        WHERE COB.CODIGOCOBRANCA = (SELECT CLI.CODIGOCOBRANCACLIENTE 
                                                FROM VSGM_CLIENTE CLI 
                                                WHERE CLI.CODIGOCLIENTE = @CODIGOCLIENTE)) 
                        ORDER BY COB.NOMECOBRANCA ASC";
            case "D":
                return @"SELECT cob.CODIGOCOBRANCA, cob.NOMECOBRANCA, cob.NIVELVENDACOBRANCA, cob.ACEITACARTAOCOBRANCA, cob.ACEITABOLETOCOBRANCA, cob.VALORMINIMOCOBRANCA, cob.CODIGOUNIDADE
                           FROM vsgm_cobranca cob
                        left JOIN vsgm_cliente_cobranca cliCo ON cliCo.codigoCobranca = cob.codigoCobranca 
                        ORDER BY cob.nomeCobranca ASC";

            default:
                return "";
        }
    }

    public static string PaymentPlan(string consult = "")
    {
        switch (consult)
        {
            case "A":
                return @"SELECT PLA.CODIGOPLANOPAGAMENTO, PLA.DESCRICAOPLANOPAGAMENTO, PLA.NUMERODIASPLANOPAGAMENTO, PLA.DATAVENCIMENTO1PLANOPAGAMENTO, PLA.DATAVENCIMENTO2PLANOPAGAMENTO, PLA.DATAVENCIMENTO3PLANOPAGAMENTO, PLA.PRAZO1PLANOPAGAMENTO, PLA.PRAZO2PLANOPAGAMENTO, PLA.PRAZO3PLANOPAGAMENTO, PLA.PRAZO4PLANOPAGAMENTO, PLA.PRAZO5PLANOPAGAMENTO, PLA.PRAZO6PLANOPAGAMENTO, PLA.PRAZO7PLANOPAGAMENTO, PLA.PRAZO8PLANOPAGAMENTO, PLA.PRAZO9PLANOPAGAMENTO, PLA.PRAZO10PLANOPAGAMENTO, PLA.PRAZO11PLANOPAGAMENTO, PLA.PRAZO12PLANOPAGAMENTO, PLA.VALORMINIMOPLANOPAGAMENTO, PLA.CODIGOTABELAPRECO, PLA.TIPORESTRICAOPLANOPAGAMENTO, PLA.CODIGORESTRICAOPLANOPAGAMENTO, PLA.TIPOVENDAPLANOPAGAMENTO, PLA.MARGEMMINIMAPLANOPAGAMENTO, PLA.ACRESCIMODESCONTOMAXIMO, PLA.TIPOPRAZOPLANOPAGAMENTO, PLA.CODIGOUNIDADE, PLA.TIPOENTRADAPLANOPAGAMENTO, PLA.VENDABOLETOPLANOPAGAMENTO, PLA.FORMAPARCELAPLANOPAGAMENTO, PLA.VALORMINPARCELAPLANOPAGAMENTO, PLA.DIASMINPARCELAPLANOPAGAMENTO, PLA.DIASMAXPARCELAPLANOPAGAMENTO, PLA.QTDPARCELAPLANOPAGAMENTO, PLA.QTDMINIMADEITENSPLANOPAGAMENTO, PLA.USAPLANOFV 
                        FROM VSGM_PLANO_PAGAMENTO PLA, VSGM_CLIENTE_PLANO CLIPLA 
                        WHERE CLIPLA.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO 
                        AND CLIPLA.CODIGOCLIENTE = @CODIGOCLIENTE 
                        AND NVL(PLA.USAPLANOFV, 'N') = 'S' 
                        AND (PLA.CODIGOUNIDADE = '12' OR PLA.CODIGOUNIDADE = '99') 
                        ORDER BY PLA.DESCRICAOPLANOPAGAMENTO ASC";

            case "B":
                return @"SELECT PLA.CODIGOPLANOPAGAMENTO, PLA.DESCRICAOPLANOPAGAMENTO, PLA.NUMERODIASPLANOPAGAMENTO, PLA.DATAVENCIMENTO1PLANOPAGAMENTO, PLA.DATAVENCIMENTO2PLANOPAGAMENTO, PLA.DATAVENCIMENTO3PLANOPAGAMENTO, PLA.PRAZO1PLANOPAGAMENTO, PLA.PRAZO2PLANOPAGAMENTO, PLA.PRAZO3PLANOPAGAMENTO, PLA.PRAZO4PLANOPAGAMENTO, PLA.PRAZO5PLANOPAGAMENTO, PLA.PRAZO6PLANOPAGAMENTO, PLA.PRAZO7PLANOPAGAMENTO, PLA.PRAZO8PLANOPAGAMENTO, PLA.PRAZO9PLANOPAGAMENTO, PLA.PRAZO10PLANOPAGAMENTO, PLA.PRAZO11PLANOPAGAMENTO, PLA.PRAZO12PLANOPAGAMENTO, PLA.VALORMINIMOPLANOPAGAMENTO, PLA.CODIGOTABELAPRECO, PLA.TIPORESTRICAOPLANOPAGAMENTO, PLA.CODIGORESTRICAOPLANOPAGAMENTO, PLA.TIPOVENDAPLANOPAGAMENTO, PLA.MARGEMMINIMAPLANOPAGAMENTO, PLA.ACRESCIMODESCONTOMAXIMO, PLA.TIPOPRAZOPLANOPAGAMENTO, PLA.CODIGOUNIDADE, PLA.TIPOENTRADAPLANOPAGAMENTO, PLA.VENDABOLETOPLANOPAGAMENTO, PLA.FORMAPARCELAPLANOPAGAMENTO, PLA.VALORMINPARCELAPLANOPAGAMENTO, PLA.DIASMINPARCELAPLANOPAGAMENTO, PLA.DIASMAXPARCELAPLANOPAGAMENTO, PLA.QTDPARCELAPLANOPAGAMENTO, PLA.QTDMINIMADEITENSPLANOPAGAMENTO, PLA.USAPLANOFV 
                        FROM VSGM_PLANO_PAGAMENTO PLA, VSGM_CLIENTE_PLANO CLIPLA, VSGM_COBRANCA_PAGAMENTO COP 
                        WHERE CLIPLA.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO 
                        AND COP.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO 
                        AND CLIPLA.CODIGOCLIENTE = @CODIGOCLIENTE 
                        AND COP.CODIGOCOBRANCA = '@CODIGOCOBRANCA' 
                        AND NVL(PLA.USAPLANOFV, 'N') = 'S' 
                        AND (PLA.CODIGOUNIDADE = '12' OR PLA.CODIGOUNIDADE = '99') 
                        ORDER BY PLA.DESCRICAOPLANOPAGAMENTO ASC";

            case "C":
                return @"SELECT PLA.CODIGOPLANOPAGAMENTO,
                               PLA.DESCRICAOPLANOPAGAMENTO,
                               PLA.NUMERODIASPLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO1PLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO2PLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO3PLANOPAGAMENTO,
                               PLA.PRAZO1PLANOPAGAMENTO,
                               PLA.PRAZO2PLANOPAGAMENTO,
                               PLA.PRAZO3PLANOPAGAMENTO,
                               PLA.PRAZO4PLANOPAGAMENTO,
                               PLA.PRAZO5PLANOPAGAMENTO,
                               PLA.PRAZO6PLANOPAGAMENTO,
                               PLA.PRAZO7PLANOPAGAMENTO,
                               PLA.PRAZO8PLANOPAGAMENTO,
                               PLA.PRAZO9PLANOPAGAMENTO,
                               PLA.PRAZO10PLANOPAGAMENTO,
                               PLA.PRAZO11PLANOPAGAMENTO,
                               PLA.PRAZO12PLANOPAGAMENTO,
                               PLA.VALORMINIMOPLANOPAGAMENTO,
                               PLA.CODIGOTABELAPRECO,
                               PLA.TIPORESTRICAOPLANOPAGAMENTO,
                               PLA.CODIGORESTRICAOPLANOPAGAMENTO,
                               PLA.TIPOVENDAPLANOPAGAMENTO,
                               PLA.MARGEMMINIMAPLANOPAGAMENTO,
                               PLA.ACRESCIMODESCONTOMAXIMO,
                               PLA.TIPOPRAZOPLANOPAGAMENTO,
                               PLA.CODIGOUNIDADE,
                               PLA.TIPOENTRADAPLANOPAGAMENTO,
                               PLA.VENDABOLETOPLANOPAGAMENTO,
                               PLA.FORMAPARCELAPLANOPAGAMENTO,
                               PLA.VALORMINPARCELAPLANOPAGAMENTO,
                               PLA.DIASMINPARCELAPLANOPAGAMENTO,
                               PLA.DIASMAXPARCELAPLANOPAGAMENTO,
                               PLA.QTDPARCELAPLANOPAGAMENTO,
                               PLA.QTDMINIMADEITENSPLANOPAGAMENTO,
                               PLA.USAPLANOFV
                          FROM VSGM_PLANO_PAGAMENTO PLA
                         WHERE PLA.NUMERODIASPLANOPAGAMENTO <=
                               (SELECT MAX(PL.NUMERODIASPLANOPAGAMENTO)
                                  FROM VSGM_PLANO_PAGAMENTO PL, VSGM_CLIENTE CLI
                                 WHERE CLI.CODIGOPLANOPAGAMENTOCLIENTE = PL.CODIGOPLANOPAGAMENTO
                                   AND CLI.CODIGOCLIENTE = @CODIGOCLIENTE)
                           AND NVL(PLA.TIPOPRAZOPLANOPAGAMENTO, 'I') <> 'I'
                           AND NOT EXISTS
                         (SELECT *
                                  FROM VSGM_RESTRICAO_VENDA RVE
                                 WHERE RVE.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO
                                   AND (RVE.CODIGOCLIENTE = @CODIGOCLIENTE OR
                                       RVE.CODIGOUSUARIO = @CODIGORCA))
                           AND NVL(PLA.USAPLANOFV, 'N') = 'S'
                           AND (PLA.CODIGOUNIDADE = '12' OR PLA.CODIGOUNIDADE = '99')
                         ORDER BY PLA.DESCRICAOPLANOPAGAMENTO ASC";

            case "D":
                return @"SELECT PLA.CODIGOPLANOPAGAMENTO, PLA.DESCRICAOPLANOPAGAMENTO, PLA.NUMERODIASPLANOPAGAMENTO, PLA.DATAVENCIMENTO1PLANOPAGAMENTO, PLA.DATAVENCIMENTO2PLANOPAGAMENTO, PLA.DATAVENCIMENTO3PLANOPAGAMENTO, PLA.PRAZO1PLANOPAGAMENTO, PLA.PRAZO2PLANOPAGAMENTO, PLA.PRAZO3PLANOPAGAMENTO, PLA.PRAZO4PLANOPAGAMENTO, PLA.PRAZO5PLANOPAGAMENTO, PLA.PRAZO6PLANOPAGAMENTO, PLA.PRAZO7PLANOPAGAMENTO, PLA.PRAZO8PLANOPAGAMENTO, PLA.PRAZO9PLANOPAGAMENTO, PLA.PRAZO10PLANOPAGAMENTO, PLA.PRAZO11PLANOPAGAMENTO, PLA.PRAZO12PLANOPAGAMENTO, PLA.VALORMINIMOPLANOPAGAMENTO, PLA.CODIGOTABELAPRECO, PLA.TIPORESTRICAOPLANOPAGAMENTO, PLA.CODIGORESTRICAOPLANOPAGAMENTO, PLA.TIPOVENDAPLANOPAGAMENTO, PLA.MARGEMMINIMAPLANOPAGAMENTO, PLA.ACRESCIMODESCONTOMAXIMO, PLA.TIPOPRAZOPLANOPAGAMENTO, PLA.CODIGOUNIDADE, PLA.TIPOENTRADAPLANOPAGAMENTO, PLA.VENDABOLETOPLANOPAGAMENTO, PLA.FORMAPARCELAPLANOPAGAMENTO, PLA.VALORMINPARCELAPLANOPAGAMENTO, PLA.DIASMINPARCELAPLANOPAGAMENTO, PLA.DIASMAXPARCELAPLANOPAGAMENTO, PLA.QTDPARCELAPLANOPAGAMENTO, PLA.QTDMINIMADEITENSPLANOPAGAMENTO, PLA.USAPLANOFV 
                        FROM VSGM_PLANO_PAGAMENTO PLA, VSGM_COBRANCA_PAGAMENTO COP 
                        WHERE COP.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO 
                        AND 1 = 1 
                        AND PLA.NUMERODIASPLANOPAGAMENTO <= (SELECT MAX(PL.NUMERODIASPLANOPAGAMENTO) 
                                                            FROM VSGM_PLANO_PAGAMENTO PL, VSGM_CLIENTE CLI 
                                                            WHERE CLI.CODIGOPLANOPAGAMENTOCLIENTE = PL.CODIGOPLANOPAGAMENTO 
                                                            AND CLI.CODIGOCLIENTE = @CODIGOCLIENTE) 
                        AND NVL(PLA.TIPOPRAZOPLANOPAGAMENTO, 'I') <> 'I' 
                        AND NOT EXISTS (SELECT RVE.CODIGORESTRICAO 
                                        FROM VSGM_RESTRICAO_VENDA RVE 
                                        WHERE RVE.CODIGOPLANOPAGAMENTO = PLA.CODIGOPLANOPAGAMENTO 
                                        AND (RVE.CODIGOCLIENTE = @CODIGOCLIENTE OR RVE.CODIGOUSUARIO = @CODIGORCA)) 
                        AND COP.CODIGOCOBRANCA = '@CODIGOCOBRANCA' 
                        AND NVL(PLA.USAPLANOFV, 'N') = 'S' 
                        AND (PLA.CODIGOUNIDADE = '12' OR PLA.CODIGOUNIDADE = '99') 
                        ORDER BY PLA.DESCRICAOPLANOPAGAMENTO ASC";

            default:
                return @"SELECT PLA.CODIGOPLANOPAGAMENTO,
                               PLA.DESCRICAOPLANOPAGAMENTO,
                               PLA.NUMERODIASPLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO1PLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO2PLANOPAGAMENTO,
                               PLA.DATAVENCIMENTO3PLANOPAGAMENTO,
                               PLA.PRAZO1PLANOPAGAMENTO,
                               PLA.PRAZO2PLANOPAGAMENTO,
                               PLA.PRAZO3PLANOPAGAMENTO,
                               PLA.PRAZO4PLANOPAGAMENTO,
                               PLA.PRAZO5PLANOPAGAMENTO,
                               PLA.PRAZO6PLANOPAGAMENTO,
                               PLA.PRAZO7PLANOPAGAMENTO,
                               PLA.PRAZO8PLANOPAGAMENTO,
                               PLA.PRAZO9PLANOPAGAMENTO,
                               PLA.PRAZO10PLANOPAGAMENTO,
                               PLA.PRAZO11PLANOPAGAMENTO,
                               PLA.PRAZO12PLANOPAGAMENTO,
                               PLA.VALORMINIMOPLANOPAGAMENTO,
                               PLA.CODIGOTABELAPRECO,
                               PLA.TIPORESTRICAOPLANOPAGAMENTO,
                               PLA.CODIGORESTRICAOPLANOPAGAMENTO,
                               PLA.TIPOVENDAPLANOPAGAMENTO,
                               PLA.MARGEMMINIMAPLANOPAGAMENTO,
                               PLA.ACRESCIMODESCONTOMAXIMO,
                               PLA.TIPOPRAZOPLANOPAGAMENTO,
                               PLA.CODIGOUNIDADE,
                               PLA.TIPOENTRADAPLANOPAGAMENTO,
                               PLA.VENDABOLETOPLANOPAGAMENTO,
                               PLA.FORMAPARCELAPLANOPAGAMENTO,
                               PLA.VALORMINPARCELAPLANOPAGAMENTO,
                               PLA.DIASMINPARCELAPLANOPAGAMENTO,
                               PLA.DIASMAXPARCELAPLANOPAGAMENTO,
                               PLA.QTDPARCELAPLANOPAGAMENTO,
                               PLA.QTDMINIMADEITENSPLANOPAGAMENTO,
                               PLA.USAPLANOFV
                          from vsgm_plano_pagamento PLA
                         WHERE PLA.USAPLANOFV = 'S'
                           and PLA.TIPOPRAZOPLANOPAGAMENTO not in ('B')
                           AND (PLA.CODIGOUNIDADE = '12' OR PLA.CODIGOUNIDADE = '99') 
                         order by numerodiasplanopagamento";
        }
    }

    public static string Unit => @"SELECT V.codigounidade as codigo_unidade,
                                           V.razaosocialunidade as razao_social_unidade,
                                           V.cnpjunidade as cpnj_unidade,
                                           V.inscricaoestadualunidade as inscricao_estadual_unidade,
                                           V.enderecounidade as endereco_unidade,
                                           V.bairrounidade as bairro_unidade,
                                           V.cidadeunidade as cidade_unidade,
                                           V.ufunidade as uf_unidade,
                                           V.cepunidade as cep_unidade,
                                           V.telefoneunidade as telefone_unidade,
                                           V.faxunidade as fax_unidade,
                                           V.codcliunidade as cod_cli_unidade,
                                           V.usawmsunidade as usa_wms_unidade,
                                           V.logoempresa as logo_empresa
                                    FROM   vsgm_unidade V,
                                           vsgm_usuario_unidade U
                                    WHERE  V.codigounidade = U.codigounidade
                                           AND U.idusuario = @IDUSUARIO ";

    public static string Brands => @"SELECT CODIGOMARCAPRODUTO, DESCRICAOMARCAPRODUTO 
                FROM VSGM_MARCA_PRODUTO 
                ORDER BY DESCRICAOMARCAPRODUTO";

    public static string Department => @"SELECT CODIGODEPARTAMENTO, DESCRICAODEPARTAMENTO 
                FROM VSGM_DEPARTAMENTO_PRODUTO";

    public static string Sections(string departmentCode)
    {
        if (!string.IsNullOrEmpty(departmentCode))
        {
            return @"SELECT CODIGODEPARTAMENTO, CODIGOSECAO, DESCRICAOSECAO 
                 FROM VSGM_SECAO_PRODUTO 
                 WHERE CODIGODEPARTAMENTO = @CODIGODEPARTAMENTO 
                 ORDER BY DESCRICAOSECAO";
        }
        else
        {
            return @"SELECT CODIGODEPARTAMENTO, CODIGOSECAO, DESCRICAOSECAO 
                 FROM VSGM_SECAO_PRODUTO 
                 ORDER BY DESCRICAOSECAO";
        }
    }

    public static string Categories(string categories)
    {
        if (categories != null && categories.ToString() != "" && categories.ToString() != "0")
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, DESCRICAOCATEGORIA 
                 FROM vsgm_categoria_produto 
                 WHERE CODIGOSECAO = @CODIGOSECAO 
                 ORDER BY descricaocategoria";
        }
        else
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, DESCRICAOCATEGORIA 
                 FROM vsgm_categoria_produto 
                 ORDER BY descricaocategoria";
        }
    }

    public static string Subcategories(string sectionCode, string categoryCode)
    {
        if (sectionCode != null && sectionCode.ToString() != "" && categoryCode != null && categoryCode.ToString() != "")
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, CODIGOSUBCATEGORIA, DESCRICAOSUBCATEGORIA 
                 FROM VSGM_SUBCATEGORIA_PRODUTO 
                 WHERE CODIGOSECAO = @CODIGOSECAO AND CODIGOCATEGORIA = @CODIGOCATEGORIA 
                 ORDER BY DESCRICAOSUBCATEGORIA";
        }
        else if (sectionCode != null && sectionCode.ToString() != "" && (categoryCode == null || categoryCode.ToString() == ""))
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, CODIGOSUBCATEGORIA, DESCRICAOSUBCATEGORIA 
                 FROM VSGM_SUBCATEGORIA_PRODUTO 
                 WHERE CODIGOSECAO = @CODIGOSECAO 
                 ORDER BY DESCRICAOSUBCATEGORIA";
        }
        else if ((sectionCode == null || sectionCode.ToString() == "") && categoryCode != null && categoryCode.ToString() != "")
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, CODIGOSUBCATEGORIA, DESCRICAOSUBCATEGORIA 
                 FROM VSGM_SUBCATEGORIA_PRODUTO 
                 WHERE CODIGOCATEGORIA = @CODIGOCATEGORIA 
                 ORDER BY DESCRICAOSUBCATEGORIA";
        }
        else
        {
            return @"SELECT CODIGOSECAO, CODIGOCATEGORIA, CODIGOSUBCATEGORIA, DESCRICAOSUBCATEGORIA 
                 FROM VSGM_SUBCATEGORIA_PRODUTO 
                 ORDER BY DESCRICAOSUBCATEGORIA";
        }
    }

    public static string ProductsImage => @"SELECT M.IMGPRODUTO from VSGM_PRODUTO_LISTA m where M.IMGPRODUTO is not null and codigoproduto = :CODIGOPRODUTO";

    public static string ProductsResume(Dictionary<string, string> options)
    {
        string baseQuery = @"SELECT     CODIGOPRODUTO,
                                    DESCRICAOPRODUTO,
                                    M.MARCA,
                                    EMBALAGEMPRODUTO,
                                    UNIDADEVENDA,
                                    (PKG_ESTOQUE.ESTOQUE_DISPONIVEL(M.CODIGOPRODUTO, :CODIGOUNIDADE, 'V')) AS ESTOQUEDISPONIVEL,

                                    '{' || '""precoTabela"": ' ||

                                              TO_CHAR(ROUND(DECODE(NVL((SELECT C.CALCULAST || C.CLIENTEFONTEST || C.SIMPLESNACIONAL FROM PCCLIENT C WHERE C.CODCLI = :CODIGOCLIENTE), 'NNN'),'SNN',
                                              T.PVENDA1 - ((T.PVENDA1 * (:PERACRESCIMODESCONTO * -1))/100),
                                    'SSN',
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100), 
                                    'NNS',
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100) - (((T.PVENDA1 - NVL(VLST,0)) * NVL(T.PERCDESCSIMPLESNAC,0))/100),
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100)

                                    ),2),'FM999999990.00')

                                    || ',' || '""precoSemImposto"": ' ||

                                              TO_CHAR(ROUND(DECODE(NVL((SELECT C.CALCULAST || C.CLIENTEFONTEST || C.SIMPLESNACIONAL FROM PCCLIENT C WHERE C.CODCLI = :CODIGOCLIENTE), 'NNN'),'SNN',
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0))* (:PERACRESCIMODESCONTO * -1))/100),
                                    'SSN',
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100), 
                                    'NNS',
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100) - (((T.PVENDA1 - NVL(VLST,0)) * NVL(T.PERCDESCSIMPLESNAC,0))/100),
                                              (T.PVENDA1 - NVL(VLST,0)) - (((T.PVENDA1 - NVL(VLST,0)) * (:PERACRESCIMODESCONTO * -1))/100)
                                    ),2),'FM999999990.00')
                                    || ',' ||
                                    '""precoMaximo"": 0.00,""precoMinimo"": 0.00,""percentualDescontoFlexivel"": 0.00,""percentualDescontoAutomatico"": 0.00,""percentualAcrescimoMaximo"": 0.00}' AS DADOS_COMERCIAIS,

                                    MIXCLIENTE,
                                    CODIGODEPARTAMENTO,
                                    CODIGOSECAO,
                                    CODIGOCATEGORIA,
                                    CODIGOSUBCATEGORIA,
                                    CODIGOMARCA,
                                    CODIGOFORNECEDOR,
                                    (SELECT DECODE(count(*),0,'N','S')
                                    FROM TABCAMPANHASHELF T
                                    WHERE T.CODIGOPRODUTO = M.CODIGOPRODUTO
                                    and T.DATAINICIO <= trunc(sysdate)
                                    and t.datafinal >= trunc(sysdate)
                                    and nvl(t.situacao, 'A') = 'A') AS POSSUICAMPANHASHELF,
                                    P.QTUNITCX    AS QTEMBALAGEMVENDA,
                                    m.IMGPRODUTO as IMGPRODUTO
                                    from VSGM_PRODUTO_LISTA m, 
                                    pctabpr t,
                                    pcprodut p 
                                    where m.codigoproduto = t.codprod
                                    and   m.codigoproduto = p.codprod
                                    and   t.numregiao = :CODIGOREGIAO
                                    and   NVL(t.PVENDA1,0) > 0
                                    ORDER BY DESCRICAOPRODUTO";

        foreach (var option in options)
        {
            switch (option.Key)
            {
                case "CODIGODEPARTAMENTO":
                    baseQuery += " AND CODIGODEPARTAMENTO = " + option.Value;
                    break;
                case "CODIGOSECAO":
                    baseQuery += " AND CODIGOSECAO = " + option.Value;
                    break;
                case "CODIGOCATEGORIA":
                    baseQuery += " AND CODIGOCATEGORIA = " + option.Value;
                    break;
                case "CODIGOSUBCATEGORIA":
                    baseQuery += " AND CODIGOSUBCATEGORIA = " + option.Value;
                    break;
                case "CODIGOMARCA":
                    baseQuery += " AND CODIGOMARCA = " + option.Value;
                    break;
                case "CODIGOFORNECEDOR":
                    baseQuery += " AND CODIGOFORNECEDOR = " + option.Value;
                    break;
                case "ESTOQUE":
                    baseQuery += " AND NVL(ESTOQUEDISPONIVEL,0) > " + option.Value;
                    break;
                case "MIXCLIENTE":
                    baseQuery += " AND MIXCLIENTE = " + option.Value;
                    break;
                default:
                    break;
            }
        }

        return baseQuery;
    }

    public static string ProductsFull => @"SELECT  P.CODIGOPRODUTO,
          P.CODIGOPRODUTOPRINCIPAL,
          P.DESCRICAOPRODUTO,
          P.EMBALAGEMPRODUTO,
          P.UNIDADEVENDA,
          P.PESOEMBALAGEMVENDA,
          P.CODIGODEPARTAMENTO,
          P.CODIGOSECAO,
          P.CODIGOCATEGORIA,
          P.CODIGOSUBCATEGORIA,
          P.CODIGOMARCA,
          P.QTEMBALAGEMVENDA,
          P.EMBALAGEMCOMPRA,
          P.UNIDADECOMPRA,
          P.QTDEMBALAGEMCOMPRA,
          P.CODIGOFORNECEDOR,
          P.DATACADASTRO,
          P.CODIGOEAN,
          P.CODIGODUN,
          P.REFERENCIA,
          P.CODIGODISTRIBUICAO,
          NVL(F.COMISSAOVENDEDORINTERNO, P.COMISSAOVENDEDORINTERNO) AS COMISSAOVENDEDORINTERNO,
          NVL(F.COMISSAOREPRESENTANTE, P.COMISSAOREPRESENTANTE) AS COMISSAOREPRESENTANTE,
          NVL(F.COMISSAOVENDEDOREXTERNO, P.COMISSAOVENDEDOREXTERNO) AS COMISSAOVENDEDOREXTERNO,
          P.INFORMACOESTECNICAS,
          P.CAMINHOFOTOPRODUTO,
          P.ACEITAVENDAFRACAO,
          P.PESOVARIAVEL,
          P.NCMPRODUTO,
          P.TIPOESTOQUEPRODUTO,
          P.TIPOESTOQUE,
          F.ACEITAVENDAFRACIONADA,
          NVL(F.CHECAMULTIPLOVENDABNF, 'S') AS CHECAMULTIPLOVENDABNF,
          NVL(F.MULTIPLOPRODUTO, P.QTDEMBALAGEMCOMPRA) AS MULTIPLOPRODUTO,
          F.QTDMINIMAPRECOATACADO,
          (PKG_ESTOQUE.ESTOQUE_DISPONIVEL(P.CODIGOPRODUTO, F.CODIGOUNIDADE, 'V')) AS ESTOQUEDISPONIVEL,
          sgmcontrol.SGM_BUSCAR_DADOS_PRECO(F.CODIGOUNIDADE,P.CODIGOPRODUTO,@CODIGOCLIENTE,@CODIGOREGIAO,'@UF',@CODIGOATIVIDADE,@CODIGOREDE,@CODIGORCA,@CODIGOSUPERVISOR,@CODIGOPLANO) AS DADOS_COMERCIAIS,
          (SELECT DECODE(count(*), 0, 'N', 'S')
          FROM TABCAMPANHASHELF T
          WHERE T.CODIGOPRODUTO = P.CODIGOPRODUTO
            and T.DATAINICIO <= trunc(sysdate)
            and t.datafinal >= trunc(sysdate)
            and nvl(t.situacao, 'A') = 'A') AS POSSUICAMPANHASHELF,
          P.INFORMACOESTECNICAS,
	          P.IMGPRODUTO,
          
          sgmcontrol.SGM_BUSCARHISTORICOITEM(@CODIGOCLIENTE,p.CODIGOPRODUTO,f.CODIGOUNIDADE) AS DADOS_HISTORICOS
            
          
        FROM VSGM_PRODUTO P, VSGM_PRODUTO_UNIDADE F
        WHERE P.CODIGOPRODUTO = F.CODIGOPRODUTO
        AND P.CODIGOPRODUTO = @CODIGOPRODUTO
        AND F.CODIGOUNIDADE = '@CODIGOUNIDADE'";

    public static string Supplier => @"SELECT F.CODFORNEC AS CODIGO,
			   UPPER(F.FORNECEDOR) AS RAZAOSOCIAL,
			   UPPER(F.FANTASIA) AS FANTASIA
		  FROM PCFORNEC F
		 WHERE EXISTS (SELECT * FROM VSGM_PRODUTO_LISTA M WHERE M.CODIGOFORNECEDOR = F.CODFORNEC)
		 ORDER BY RAZAOSOCIAL";

    public static string ProductsValidate => @"SELECT P.CODIGOCAMPANHA, 
                                                      E.DATAVALIDADE, 
                                                      E.ESTOQUE, 
                                                      P.PRECO AS PRECOPROMOCIONAL, 
                                                      (E.DATAVALIDADE - E.PRAZOVALIDADE) AS DATAFABRICACAO, 
                                                      (E.DATAVALIDADE - trunc(sysdate)) AS DIASVALIDADE
				FROM VSGM_ESTOQUE_PRODUTO E
				LEFT JOIN TABCAMPANHASHELF P
				ON (P.CODIGOPRODUTO = E.CODIGOPRODUTO AND
					P.DATAVALIDADE = E.DATAVALIDADE
					AND P.DATAINICIO <= TRUNC(SYSDATE) 
					AND P.DATAFINAL >= TRUNC(SYSDATE)
					and nvl(p.situacao, 'A') = 'A')
			WHERE E.CODIGOUNIDADE = @CODIGOUNIDADE
				AND E.CODIGOPRODUTO = @CODIGOPRODUTO
			ORDER BY E.DATAVALIDADE";



    public static string ProductValidate => @"SELECT P.CODIGOCAMPANHA, E.DATAVALIDADE, E.ESTOQUE, P.PRECO AS PRECOPROMOCIONAL
	                    FROM VSGM_ESTOQUE_PRODUTO E
	                    LEFT JOIN TABCAMPANHASHELF P
	                      ON (P.CODIGOPRODUTO = E.CODIGOPRODUTO AND
		                     P.DATAVALIDADE = E.DATAVALIDADE
		                     AND P.DATAINICIO <= TRUNC(SYSDATE) 
		                     AND P.DATAFINAL >= TRUNC(SYSDATE)
		                     and nvl(p.situacao, 'A') = 'A')
                       WHERE E.CODIGOUNIDADE = @CODIGOUNIDADE
	                     AND E.CODIGOPRODUTO = @CODIGOPRODUTO
	                     AND P.CODIGOCAMPANHA = @CODIGOCAMPANHA
                       ORDER BY E.DATAVALIDADE";
    public static string ProductsOffers => @"
        select 
            des561.CODIGODESCONTO, 
            des561.CODIGOCLIENTE, 
            des561.CODIGODEPARTAMENTO, 
            des561.CODIGOSECAO, 
            des561.CODIGOCATEGORIA, 
            des561.CODIGOPRODUTO, 
            des561.PERCENTUALDESCONTO, 
            des561.DATAINICIO, 
            des561.DATAFIM, 
            des561.CODIGOUSUARIO, 
            des561.CODIGOPLANOPAGAMENTO, 
            des561.BASECREDDEBRCA, 
            des561.UTILIZADESCREDE, 
            des561.CODIGOFORNECEDOR, 
            des561.CODIGOSUPERVISOR, 
            des561.TIPOVENDA, 
            des561.CODIGOREGIAO, 
            des561.CODFUNCLANC, 
            des561.DATALANCAMENTO, 
            des561.CODFUNCULTALTER, 
            des561.DATAULTALTER, 
            des561.UF, 
            des561.CODIGOATIVIDADE, 
            des561.ORIGEMPEDIDO, 
            des561.CODIGOPRACA, 
            des561.CODIGOPRODUTOPRINCIPAL, 
            des561.NUMORCA, 
            des561.CLASSEVENDA, 
            des561.APLICADESCONTO, 
            des561.TIPOCARGA, 
            des561.CREDITASOBREPOLITICA, 
            des561.TIPO, 
            des561.PERCDESCFIN, 
            des561.ALTERAPTABELA, 
            des561.TIPOAPLICDESCONTOCB, 
            des561.CODIGOPRODUTOCB, 
            des561.PERCCOMPROFISSIONALMINIMO, 
            des561.PERCDESCFORNEC, 
            des561.PRIORITARIA, 
            des561.QUESTIONAUSOPRIORITARIA, 
            des561.AREAATUACAO, 
            des561.CODIGOUNIDADE, 
            des561.QTDEMAXIMAPOLITICA, 
            des561.QTDEMAXIMAPEDIDO, 
            des561.CODIGOGRUPO, 
            des561.APENASPLANOPAGAMENTOMAXIMO, 
            des561.PERCOMMINT, 
            des561.PERCOMREP, 
            des561.PERCOMEXT, 
            des561.APLICADESCSIMPLESNACIONAL, 
            des561.OBSDESCONTO, 
            des561.CODIGOMARCA, 
            des561.CODIGOREDE, 
            des561.TIPOFV, 
            des561.CODIGOCONDICAOVENDA, 
            des561.PRIORITARIAGERAL, 
            des561.CONSIDERACALCGIROMEDIC, 
            des561.TIPOFJ, 
            des561.NUMROLO, 
            des561.CODIGOIDENTIFICADOR, 
            des561.CONCEDERMAIORCOMISSREG, 
            des561.PRECOFIXO, 
            des561.CODIGOCLIENTECONV, 
            des561.QTDEMINDESCONTO, 
            des561.SUBCATEGORIA, 
            des561.FISCALCAIXA, 
            des561.CODIGOLINHAPRODUTO, 
            des561.CODIGOPROMOCAOMED, 
            des561.PRAZOMAXIMOVENDA, 
            des561.CODIGOFUNC, 
            des561.PERCDESCMAX, 
            des561.QTDEINICIO, 
            des561.QTDEFIM, 
            des561.CODIGOGRUPOREST, 
            des561.TIPOGRUPOREST, 
            des561.CODIGOCOBRANCA, 
            des561.VALORMINIMO, 
            des561.VALORMAXIMO, 
            des561.TIPODESCONTO, 
            des561.CODIGOAUXILIAR, 
            des561.PERDESCFORNEC 
        from 
            vsgm_produto pro 
        inner join 
            vsgm_produto_unidade proUnd on proUnd.codigoProduto = pro.codigoProduto 
        left join 
            (select 
                des561.* 
            from 
                vsgm_desconto_561 des561 
            where 
                des561.dataInicio <= trunc(sysdate) 
                and des561.dataFim >= trunc(sysdate) 
                and des561.codigoDesconto <> 0 
                and ( 
                    (NVL(des561.codigoCliente,'0') = '0' or des561.codigoCliente = @CODIGOCLIENTE) 
                    or (NVL(des561.codigoRegiao,'0') = '0' or des561.codigoRegiao = @CODIGOREGIAOCLIENTE) 
                    or (NVL(des561.UF,'0') = '0' or des561.UF = '@UFCLIENTE') 
                    or (NVL(des561.codigoAtividade,'0') = '0' or des561.codigoAtividade = @CODIGOATIVIDADECLIENTE) 
                    or (NVL(des561.codigoRede,'0') = '0' or des561.codigoRede = @CODIGOREDECLIENTE) 
                    or (NVL(des561.codigoUsuario,'0') = '0' or des561.codigoUsuario = @CODIGORCA) 
                    or (NVL(des561.codigoSupervisor,'0') = '0' or des561.codigoSupervisor = @CODIGOSUPERVISOR) 
                    or (NVL(des561.codigoPlanoPagamento,'0') = '0' or des561.codigoPlanoPagamento = @CODIGOPLANOPAGAMENTO) 
                )) des561 on 
                (NVL(des561.codigoProduto,'0') = '0' or des561.codigoProduto = pro.codigoProduto) 
                and (NVL(des561.codigoProdutoPrincipal,'0') = '0' or des561.codigoProdutoPrincipal = pro.codigoProdutoPrincipal) 
                and (NVL(des561.codigoUnidade,'0') = '0' or des561.codigoUnidade = proUnd.codigoUnidade) 
                and (NVL(des561.codigoDepartamento,'0') = '0' or des561.codigoDepartamento = pro.codigoDepartamento) 
                and (NVL(des561.codigoSecao,'0') = '0' or des561.codigoSecao = pro.codigoSecao) 
                and (NVL(des561.codigoCategoria,'0') = '0' or des561.codigoCategoria = pro.codigoCategoria) 
                and (NVL(des561.codigoFornecedor,'0') = '0' or des561.codigoFornecedor = pro.codigoFornecedor) 
                and (NVL(des561.codigoMarca,'0') = '0' or des561.codigoMarca = pro.codigoMarca) 
                and (NVL(des561.codigoUsuario,'0') = '0' or des561.codigoUsuario = @CODIGORCA) 
                and (NVL(des561.codigoSupervisor,'0') = '0' or des561.codigoSupervisor = @CODIGOSUPERVISOR) 
        where 
            proUnd.codigoUnidade = @CODIGOUNIDADE 
            and pro.codigoProduto = @CODIGOPRODUTO 
            and (1.0 >= NVL(des561.qtdeInicio, 0) and (1.0 <= NVL(des561.qtdeFim, 0) or NVL(des561.qtdeFim, 0) = 0) ) 
        order by 
            NVL(des561.prioritariaGeral, 'N') desc, 
            NVL(des561.prioritaria, 'N') desc, 
            des561.percentualDesconto desc, 
            cast(des561.codigoDesconto as integer) desc";

    public static string Regions => @"
        SELECT DECODE(
            (SELECT COUNT(*)
             FROM PCTABPRCLI T
             WHERE T.CODCLI = C.CODCLI AND T.CODFILIALNF = @CODIGOUNIDADE),
            0,
            P.NUMREGIAO,
            (SELECT T.NUMREGIAO
             FROM PCTABPRCLI T
             WHERE T.CODCLI = C.CODCLI AND T.CODFILIALNF = @CODIGOUNIDADE)
        ) AS CODIGOREGIAOCLIENTE
        FROM PCCLIENT C, PCPRACA P
        WHERE C.CODPRACA = P.CODPRACA AND C.CODCLI = @CODIGOCLIENTE";

    public static string Atendimento => @"
          SELECT  C.CODCLI AS codigo_cliente,
                  C.CLIENTE AS razao_social,
                  C.FANTASIA AS fantasia,
                  c.Cgcent AS cnpj,
                  C.ENDERENT AS endereco_entrega,
                  C.NUMEROENT AS numero_entrega,
                  C.BAIRROENT AS bairro_entrega,
                  c.Municent AS cidade_entrega,
                  C.ESTENT AS uf_entrega,
                  C.LIMCRED as limite_credito,
                  SGMCONTROL.SGM_BUSCARLIMCREDCLI(C.CODCLI, NULL, 'D', 'S') AS saldo_disponivel,
                  C.DTPRIMCOMPRA AS data_primeira_compra,
                  C.DTULTCOMP AS data_ultima_compra,
                  TRUNC((C.DTULTCOMP - C.Dtprimcompra) / 30)  AS tempo_relacionamento,
                  TRUNC(SYSDATE) - C.DTULTCOMP AS dias_sem_compra,
                  (select NVL(round(avg(NVL(T.dtpag,TRUNC(SYSDATE)) - T.dtvenc), 2), 0)
                  from pcprest T
                  where T.codcli = C.CODCLI) AS media_atraso,
                  NVL(to_number((select COUNT(*)
                    from pcprest T
                    where T.dtpag is null
                    and T.dtcancel is null
                    and T.DTVENC < Trunc(SYSDATE)
                    AND T.codcli = C.CODCLI
                    AND T.CODFILIAL = @CODIGOUNIDADE)),
                    0) AS titulos_vencidos,
                  NVL(to_number((select COUNT(*)
                    from pcprest T
                    where T.dtpag is null
                    and T.dtcancel is null
                    and T.DTVENC >= Trunc(SYSDATE)
                    AND T.codcli = C.CODCLI
                    AND T.CODFILIAL = @CODIGOUNIDADE)),
                    0) AS titulos_a_vencer,
                  to_number((SELECT MAX(PED.VLATEND)
                  FROM PCPEDC PED
                  WHERE PED.CODCLI = C.CODCLI
                    AND PED.POSICAO not in ('C')
                    AND PED.CODFILIAL = @CODIGOUNIDADE)) AS maior_compra,
                  to_number((SELECT MIN(PED.VLATEND)
                  FROM PCPEDC PED
                  WHERE PED.CODCLI = C.CODCLI
                    AND PED.POSICAO not in ('C')
                    AND PED.CODFILIAL = @CODIGOUNIDADE)) AS menor_compra,
            
                    ROUND( (SELECT to_number(AVG(PED.VLATEND))
                  FROM PCPEDC PED
                  WHERE PED.CODCLI = C.CODCLI
                    AND PED.POSICAO not in ('C')
                    AND PED.CODFILIAL = @CODIGOUNIDADE),2)  AS ticket_medio,        
                  NVL(TO_CHAR(
                            TO_NUMBER(
                              REPLACE(
                                TO_CHAR(
                                  (SELECT AVG(T.DTVENC - T.DTEMISSAO)
                                   FROM pcprest T
                                   WHERE T.dtpag IS NULL
                                     AND T.dtcancel IS NULL
                                     AND T.DTVENC >= Trunc(SYSDATE)
                                     AND T.codcli = C.CODCLI
                                     AND T.CODFILIAL = @CODIGOUNIDADE
                                  ),
                                  '999999999.99'  -- Formato genérico
                                ),
                                ',',
                                '.'
                              ),
                              '999999999.99'  -- Formato genérico
                            ),
                            '999999999.99'  -- Formato genérico
                          ),
                          '0')                          AS prazo_medio_pagamento,
        
                (SELECT COUNT(DISTINCT(ITE.CODPROD))
                  FROM PCPEDC PED,
                      PCPEDI ITE
                  WHERE PED.NUMPED = ITE.NUMPED
                    AND PED.CODCLI = C.CODCLI
                    AND PED.POSICAO not in ('C')
                    AND PED.CODFILIAL = @CODIGOUNIDADE)    AS mix_ideal
                  FROM PCCLIENT C
                  WHERE C.CODCLI = @CODIGOCLIENTE";

    public static string HistoricoVendas => @"
        SELECT 
            PCPEDI.CODCLI,
            PCCLIENT.CLIENTE,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '01',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_01,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '02',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_02,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '03',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_03,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '04',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_04,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '05',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_05,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '06',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_06,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '07',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_07,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '08',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_08,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '09',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_09,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '10',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_10,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '11',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_11,
            SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
                '12',
                (NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))),
                0)) AS valor_venda_12,
            SUM(NVL(PCPEDI.QT, 0) *
                (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
                NVL(PCPEDI.VLFRETE, 0))) valor_venda_total
          
            FROM PCPEDC,
            PCPEDI,
            PCCLIENT
        
            WHERE pcpedc.DATA between trunc(add_months(sysdate,-6),'month') and last_day(sysdate)
            AND PCPEDC.NUMPED = PCPEDI.NUMPED
            AND PCPEDC.CODCLI = PCCLIENT.CODCLI
            AND PCPEDC.DTCANCEL IS NULL
            AND PCPEDC.CODFILIAL = @CODIGOUNIDADE
            AND PCPEDC.CODCLI = @CODIGOCLIENTE
            AND PCPEDC.CODUSUR = @CODIGORCA
            AND PCPEDC.POSICAO = 'F'
            AND PCPEDC.CONDVENDA IN (1, 2, 3, 7, 9, 14, 15, 17, 18, 19, 98)

            GROUP BY PCPEDI.CODCLI,
            PCCLIENT.CLIENTE
            ORDER BY valor_venda_total DESC";

    public static string HistoricoPedidos => @"
        SELECT
              P.DATA AS DATAPEDIDO,
              P.NUMPED AS NUMEROPEDIDO,
              DECODE(P.ORIGEMPED,'F','F - FORÇA VENDA','R','R - BALCÃO RESERVA','B','B - BALCÃO','T','T - TELEMARKETING') AS ORIGEMVENDA,
              P.NUMPEDCLI AS NUMEROPEDIDOCLIENTE,
              DECODE(P.CONDVENDA,1,'1 - VENDA NORMAL',5,'5 - BONIFICAÇÃO',11,'11 - TROCA') AS DESCRICAOCONDVENDA,
              M.DESCRICAO AS DESCRICAOPLANOPAGAMENTO,
              B.COBRANCA  AS COBRANCA,
              P.VLATEND AS VALORTOTAL,
              P.TOTPESO AS PESOBRUTO,
              P.OBSENTREGA1 || ' ' || P.OBSENTREGA2 || ' ' || P.OBSENTREGA3      AS OBSERVACOES,
              (Select count(*) 
                  from pcpedi i 
                  where i.numped = p.numped) AS QTDITENS,
              Decode(p.Posicao,'P','Pendente','B','Bloqueado','L','Liberado','M','Em Carregamento','F','Faturado') AS SITUACAO
      
              FROM PCPEDC P,
                   PCCLIENT C,
                   PCCOB B,
                   PCPLPAG M
      
      
              WHERE P.CODCLI = C.CODCLI
              AND   P.CODCOB = B.CODCOB
              AND   P.CODPLPAG = M.CODPLPAG
              AND   P.CODCLI = @CODIGOCLIENTE
              AND   P.CODFILIAL = @CODIGOUNIDADE
              AND   P.DATA BETWEEN TRUNC(ADD_MONTHS(SYSDATE,-3),'MM') AND LAST_DAY(SYSDATE)
              order by p.data desc";

    public static string HistoricoPedidosItens => @"
        SELECT
            I.CODPROD     AS CODIGOPRODUTO,
            M.DESCRICAO   AS DESCRICAO,
            I.PVENDA      AS PRECO,
            I.QT          AS QUANTIDADE,
            I.UNIDADE     AS UNIDADE,
            M.EMBALAGEM   AS EMBALAGEM,
            ROUND(I.QT * I.PVENDA,2)  AS TOTAL

        FROM PCPEDI I,
             PCPRODUT M
     
             WHERE I.CODPROD = M.CODPROD
             AND   I.NUMPED = @NUMEROPEDIDO";

    public static string Oportunidades => @"
        SELECT
          IDOPORTUNIDADE, 
          CASE WHEN TIPO = 'P' THEN 'PRODUTO'
               WHEN TIPO = 'S' THEN 'PROMOTOR'
               WHEN TIPO = 'C' THEN 'CAMPANHA'
           ELSE TIPO
          END AS TIPO,
          CODIGO, 
          DESCRICAO, 
          OBSERVACAO,
          CODIGOCLIENTE,
          CODIGOUNIDADE,
          CODIGORCA,
          STATUS    
        FROM TABOPORTUNIDADE
        WHERE CODIGOCLIENTE = @CODIGOCLIENTE
          AND CODIGOUNIDADE = @CODIGOUNIDADE
          AND CODIGORCA = @CODIGORCA
          AND STATUS = 'A'";

    public static string OportunidadesAll => @"
        SELECT
          IDOPORTUNIDADE, 
          CASE WHEN TIPO = 'P' THEN 'PRODUTO'
               WHEN TIPO = 'S' THEN 'PROMOTOR'
               WHEN TIPO = 'C' THEN 'CAMPANHA'
           ELSE TIPO
          END AS TIPO,
          CODIGO, 
          DESCRICAO, 
          OBSERVACAO,
          CODIGOCLIENTE,
          CODIGOUNIDADE,
          CODIGORCA,
          STATUS    
          FROM TABOPORTUNIDADE
          WHERE STATUS = 'A'
    ";

    public static string GetTransportadora => @"
        SELECT codfornec
              , fornecedor
              , fantasia
        FROM pcfornec
        WHERE revenda = 'T' and pcfornec.dtexclusao is NULL
    ";

    public static string InsertOportunidade => @"
        INSERT INTO TABOPORTUNIDADE (IDOPORTUNIDADE, TIPO, CODIGO, DESCRICAO, OBSERVACAO, CODIGOCLIENTE, CODIGOUNIDADE, CODIGORCA, STATUS)
        VALUES (SEQ_TABOPORTUNIDADE.NEXTVAL, '@TIPO', '@CODIGO', '@DESCRICAO', '@OBSERVACAO', '@CODCLIENTE', '@CODUNIDADE', '@CODRCA', '@STATUS')
    ";

    public static string UpdateOportunidade => @"
            UPDATE TABOPORTUNIDADE
            SET TIPO = '@TIPO', 
                CODIGO = '@CODIGO', 
                DESCRICAO = '@DESCRICAO', 
                OBSERVACAO = '@OBSERVACAO',
                CODIGOCLIENTE = '@CODCLIENTE',
                CODIGOUNIDADE = '@CODUNIDADE',
                CODIGORCA = '@CODRCA',
                STATUS = '@STATUS'
            WHERE IDOPORTUNIDADE = @IDOPORTUNIDADE
        ";

    public static string DeleteOportunidade => @"
            DELETE FROM TABOPORTUNIDADE WHERE IDOPORTUNIDADE = @IDOPORTUNIDADE
        ";

    public static string CardDevolucao => @"
        SELECT                                                           
               DEVOL.QTNF,                                                             
               DEVOL.VLTOTAL                                                                                                                 
        FROM  (SELECT CODCLI, CLIENTE, COUNT(DISTINCT NUMNOTA) QTNF,                                  
                       SUM(NVL(VLDEVOLUCAO,0) + NVL(VLDEVOLBONIFIC,0)) VLTOTAL,     
                       SUM(NVL(TOTPESO,0)) TOTPESO,                                    
                       SUM(NVL(VLOUTRAS,0) + NVL(VLFRETE,0) ) VLOUTRAS FROM ( 
        SELECT DEVOL.CODPROD,                     
            DEVOL.DESCRICAO,                      
            DEVOL.TOTPESO,                        
            DEVOL.VLOUTRAS,                       
            DEVOL.VLDEVOLUCAO,                    
            DEVOL.VLDEVOLBONIFIC,                 
            DEVOL.VLFRETE,                        
            DEVOL.CODDEVOL,                       
            DEVOL.MOTIVO,                         
            DEVOL.MOTIVO2,                        
            DEVOL.DEVOLITEM,                      
            DEVOL.NUMNOTA,                        
            DEVOL.CODMOTORISTADEVOL,              
            DEVOL.CODFORNEC,                      
            DEVOL.CODFILIAL,                      
            DEVOL.DTENT,                          
            DEVOL.CONDVENDA,                      
            DEVOL.QT,                             
            DEVOL.CODEPTO,                        
            DEVOL.UNIDADE,                        
            DEPARTAMENTO,         
            FORNECEDOR ,         
            DEVOL.SUPERV,          
            DEVOL.CODSUPERVISOR,   
            DEVOL.NOME,                  
            DEVOL.CODUSUR,                
            DEVOL.CLIENTE,                  
            DEVOL.CODCLI,                
            DEVOL.EMBALAGEM           
        FROM (                              
              SELECT VW.CODPROD,               
                    VW.DESCRICAO,              
                    VW.TOTPESO,                
                    VW.VLOUTRAS,               
                    VW.VLDEVOLUCAO,            
                    VW.VLDEVOLBONIFIC,         
                    VW.VLFRETE,                
                    VW.CODDEVOL,               
                    VW.MOTIVO,                 
                    VW.MOTIVO2,                
                    VW.DEVOLITEM,              
                    VW.NUMNOTA,                
                    VW.CODMOTORISTADEVOL,      
                    VW.CODFORNEC,              
                    VW.CODFILIAL,              
                    VW.DTENT,                  
                    VW.CONDVENDA,              
                    VW.QT,                     
                    VW.CODEPTO,                
                    VW.DEPARTAMENTO,           
                    VW.FORNECEDOR,              
                    PCSUPERV.NOME AS SUPERV,          
                    VW.CODSUPERVMOV AS CODSUPERVISOR,   
                    VW.NOME,                  
                    VW.CODUSUR,                
                    VW.CLIENTE,                  
                    VW.CODCLI,                
                    VW.UNIDADE,           
                    VW.EMBALAGEM,           
                    VW.TEMVENDATV8,  
                    VW.BONIFICADO 
               FROM VIEW_DEVOL_RESUMO_FATURAMENTO VW, PCSUPERV
                  , PCNFENT 
               WHERE VW.NUMTRANSENT = PCNFENT.NUMTRANSENT 
                  AND PCSUPERV.CODSUPERVISOR = VW.CODSUPERVMOV 
               AND PCNFENT.TIPODESCARGA <> 'T'
             UNION ALL                      
             SELECT CODPROD,                
                    DESCRICAO,              
                    TOTPESO,                
                    VLOUTRAS,               
                    VLDEVOLUCAO,            
                    0 VLDEVOLBONIFIC,       
                    VLFRETE,                
                    CODDEVOL,               
                    MOTIVO,                 
                    MOTIVO2,                
                    DEVOLITEM,              
                    NUMNOTA,                
                    CODMOTORISTADEVOL,      
                    CODFORNEC,              
                    CODFILIAL,              
                    DTENT,                  
                    0 CONDVENDA,            
                    QT,                     
                    CODEPTO,                
                    '' DEPARTAMENTO,      
                    '' FORNECEDOR,        
                    SUPERV,          
                    CODSUPERVISOR,   
                    NOME,                  
                    CODUSUR,                
                    CLIENTE,                  
                    CODCLI,                
                    UNIDADE,           
                    EMBALAGEM,           
                    NULL AS TEMVENDATV8, 
                    BONIFICADO 
               FROM VIEW_DEVOL_RESUMO_FATURAVULSA
         ) DEVOL                            
         WHERE DEVOL.CODCLI = @CODIGOCLIENTE 
          AND ((DEVOL.CONDVENDA NOT IN (4, 8, 10, 13, 20, 98, 99) AND (DEVOL.TEMVENDATV8 IS NOT  NULL)) OR 
               (DEVOL.CONDVENDA NOT IN (4, 10, 13, 20, 98, 99)    AND (DEVOL.TEMVENDATV8 IS NULL)))
               AND (DEVOL.CODFILIAL IN ( @CODIGOUNIDADE )) 
             )   GROUP BY CODCLI,CLIENTE) DEVOL                                        
                ORDER BY DEVOL.VLTOTAL DESC";

    public static string Devolucoes => @"
        SELECT 
               DEVOL.DTENT,
               DEVOL.NUMNOTA,
               DEVOL.CODPROD,                                                
               DEVOL.PRODUTO,                                                                                                 
               DEVOL.QTITENS    AS QTD,                                                
               ROUND(DEVOL.VLTOTAL,2) AS VLTOTAL,
               DEVOL.MOTIVO                                                                                            
        FROM  (SELECT  
                       DTENT,
                       NUMNOTA,
                       MOTIVO, 
                       CODPROD, 
                       DESCRICAO AS PRODUTO, 
                       SUM(NVL(VLDEVOLUCAO,0) + NVL(VLDEVOLBONIFIC,0)) VLTOTAL,     
                       SUM(NVL(QT,0)) QTITENS,                               
                       SUM(NVL(TOTPESO,0)) TOTPESO,                          
                       SUM(NVL(VLOUTRAS,0) + NVL(VLFRETE,0) ) VLOUTRAS FROM ( 
        SELECT DEVOL.CODPROD,                     
            DEVOL.DESCRICAO,                      
            DEVOL.TOTPESO,                        
            DEVOL.VLOUTRAS,                       
            DEVOL.VLDEVOLUCAO,                    
            DEVOL.VLDEVOLBONIFIC,                 
            DEVOL.VLFRETE,                        
            DEVOL.CODDEVOL,                       
            DEVOL.MOTIVO,                         
            DEVOL.MOTIVO2,                        
            DEVOL.DEVOLITEM,                      
            DEVOL.NUMNOTA,                        
            DEVOL.CODMOTORISTADEVOL,              
            DEVOL.CODFORNEC,                      
            DEVOL.CODFILIAL,                      
            DEVOL.DTENT,                          
            DEVOL.CONDVENDA,                      
            DEVOL.QT,                             
            DEVOL.CODEPTO,                        
            DEVOL.UNIDADE,                        
            DEPARTAMENTO,         
            FORNECEDOR ,         
            DEVOL.SUPERV,          
            DEVOL.CODSUPERVISOR,   
            DEVOL.NOME,                  
            DEVOL.CODUSUR,                
            DEVOL.CLIENTE,                  
            DEVOL.CODCLI,                
            DEVOL.EMBALAGEM           
        FROM (                              
              SELECT VW.CODPROD,               
                    VW.DESCRICAO,              
                    VW.TOTPESO,                
                    VW.VLOUTRAS,               
                    VW.VLDEVOLUCAO,            
                    VW.VLDEVOLBONIFIC,         
                    VW.VLFRETE,                
                    VW.CODDEVOL,               
                    VW.MOTIVO,                 
                    VW.MOTIVO2,                
                    VW.DEVOLITEM,              
                    VW.NUMNOTA,                
                    VW.CODMOTORISTADEVOL,      
                    VW.CODFORNEC,              
                    VW.CODFILIAL,              
                    VW.DTENT,                  
                    VW.CONDVENDA,              
                    VW.QT,                     
                    VW.CODEPTO,                
                    VW.DEPARTAMENTO,           
                    VW.FORNECEDOR,              
                    PCSUPERV.NOME AS SUPERV,          
                    VW.CODSUPERVMOV AS CODSUPERVISOR,   
                    VW.NOME,                  
                    VW.CODUSUR,                
                    VW.CLIENTE,                  
                    VW.CODCLI,                
                    VW.UNIDADE,           
                    VW.EMBALAGEM,           
                    VW.TEMVENDATV8,  
                    VW.BONIFICADO 
               FROM VIEW_DEVOL_RESUMO_FATURAMENTO VW, PCSUPERV
                  , PCNFENT 
               WHERE VW.NUMTRANSENT = PCNFENT.NUMTRANSENT 
                  AND PCSUPERV.CODSUPERVISOR = VW.CODSUPERVMOV 
               AND PCNFENT.TIPODESCARGA <> 'T'
             UNION ALL                      
             SELECT CODPROD,                
                    DESCRICAO,              
                    TOTPESO,                
                    VLOUTRAS,               
                    VLDEVOLUCAO,            
                    0 VLDEVOLBONIFIC,       
                    VLFRETE,                
                    CODDEVOL,               
                    MOTIVO,                 
                    MOTIVO2,                
                    DEVOLITEM,              
                    NUMNOTA,                
                    CODMOTORISTADEVOL,      
                    CODFORNEC,              
                    CODFILIAL,              
                    DTENT,                  
                    0 CONDVENDA,            
                    QT,                     
                    CODEPTO,                
                    '' DEPARTAMENTO,      
                    '' FORNECEDOR,        
                    SUPERV,          
                    CODSUPERVISOR,   
                    NOME,                  
                    CODUSUR,                
                    CLIENTE,                  
                    CODCLI,                
                    UNIDADE,           
                    EMBALAGEM,           
                    NULL AS TEMVENDATV8, 
                    BONIFICADO 
               FROM VIEW_DEVOL_RESUMO_FATURAVULSA
         ) DEVOL                            
         WHERE DEVOL.CODCLI = @CODIGOCLIENTE
          AND ((DEVOL.CONDVENDA NOT IN (4, 8, 10, 13, 20, 98, 99) AND (DEVOL.TEMVENDATV8 IS NOT  NULL)) OR 
               (DEVOL.CONDVENDA NOT IN (4, 10, 13, 20, 98, 99)    AND (DEVOL.TEMVENDATV8 IS NULL)))
               AND (DEVOL.CODFILIAL IN ( @CODIGOUNIDADE )) 
              )  GROUP BY DTENT,
                       NUMNOTA,
                       MOTIVO, CODPROD ,DESCRICAO) DEVOL                          
                ORDER BY DEVOL.VLTOTAL DESC ";

    public static string Titulos => @"
        SELECT
          pcprest.duplic            AS DUPLICATA,
          pcprest.prest             AS PARCELA,
          pcprest.codcob            AS CODIGOCOBRANCA,
          PCCOB.Cobranca            AS COBRANCA,
          NVL (pcprest.valor, 0) AS valorOriginal,
          CASE WHEN PCPREST.dtvenc >= TRUNC (SYSDATE) THEN 0 ELSE TRUNC(SYSDATE) - PCPREST.DTVENC END AS DIASATRASO,
          CASE WHEN PCPREST.dtvenc >= TRUNC (SYSDATE) THEN 0 ELSE ROUND(((PCPREST.VALOR * PCCOB.PERCMULTA)/100),2) END AS VALORMULTA,
          CASE WHEN PCPREST.dtvenc >= TRUNC (SYSDATE) THEN 0 ELSE round(((PCPREST.VALOR * (PCCOB.TXJUROS / 30))/100),2) END AS VALORJUROS,
          CASE WHEN PCPREST.dtvenc >= TRUNC (SYSDATE) THEN NVL (pcprest.valor, 0) ELSE ROUND((NVL (pcprest.valor, 0) + ROUND(((PCPREST.VALOR * PCCOB.PERCMULTA)/100),2) + round(((PCPREST.VALOR * (PCCOB.TXJUROS / 30))/100),2)),2) END AS ValorAtualizado,
          pcprest.dtemissao         AS DATAEMISSAO,
          pcprest.dtvenc            AS DATAVENCIMENTO,
          pcprest.dtpag             AS DATAPAGAMENTO,
          CASE WHEN pcprest.dtvenc >= TRUNC (SYSDATE) THEN 'A VENCER' ELSE 'VENCIDOS' END
             AS SITUACAO,
           CASE WHEN pcprest.dtvenc >= TRUNC (SYSDATE) THEN PCPREST.LINHADIG ELSE ' ' END    AS CODBARRASBOLETO

     FROM pcprest,
          pcclient,
          pcusuari,
          pccob
    WHERE pccob.codcob = pcprest.codcob
      AND pcusuari.codusur = pcprest.codusur
      AND pcclient.codcli = pcprest.codcli
      AND pcprest.dtpag IS NULL
      AND pcprest.codcob NOT IN ('BNF', 'BNFT', 'BNFR', 'BNTR', 'BNRP', 'CRED','DESD','ESTR')
      and pcprest.codcli = @CODIGOCLIENTE
      and pcprest.codfilial = @CODIGOUNIDADE
      
      UNION
      
      SELECT
          pcprest.duplic            AS DUPLICATA,
          pcprest.prest             AS PARCELA,
          pcprest.codcob            AS CODIGOCOBRANCA,
          PCCOB.Cobranca            AS COBRANCA,
          NVL (pcprest.valor, 0) AS valorOriginal,
          CASE WHEN PCPREST.dtvenc >= pcprest.dtpag THEN 0 ELSE PCPREST.DTPAG - PCPREST.DTVENC END AS DIASATRASO,
          CASE WHEN PCPREST.dtvenc >= pcprest.dtpag THEN 0 ELSE ROUND(((PCPREST.VALOR * PCCOB.PERCMULTA)/100),2) END AS VALORMULTA,
          CASE WHEN PCPREST.dtvenc >= pcprest.dtpag THEN 0 ELSE round(((PCPREST.VALOR * (PCCOB.TXJUROS / 30))/100),2) END AS VALORJUROS,
          pcprest.vpago AS ValorAtualizado,
          pcprest.dtemissao         AS DATAEMISSAO,
          pcprest.dtvenc            AS DATAVENCIMENTO,
          pcprest.dtpag             AS DATAPAGAMENTO,
          'BAIXADO'                 AS SITUACAO,
          NULL                      AS CODBARRASBOLETO

     FROM pcprest,
          pcclient,
          pcusuari,
          pccob
    WHERE pccob.codcob = pcprest.codcob
      AND pcusuari.codusur = pcprest.codusur
      AND pcclient.codcli = pcprest.codcli
      and pcprest.dtpag is not null
      AND pcprest.dtemissao BETWEEN TRUNC(ADD_MONTHS(SYSDATE,-6),'MM') AND LAST_DAY(ADD_MONTHS(SYSDATE,-1))
      AND pcprest.codcob NOT IN ('BNF', 'BNFT', 'BNFR', 'BNTR', 'BNRP', 'CRED','DESD','ESTR')
      and pcprest.codcli = @CODIGOCLIENTE
      and pcprest.codfilial = @CODIGOUNIDADE
        ORDER BY DATAEMISSAO DESC";

    public static string MixIdeal => @"
        SELECT pcprodut.codprod as CODIGOPRODUTO,
               pcprodut.descricao as DESCRICAOPRODUTO,
               NVL (pcembalagem.embalagem, pcprodut.embalagem) EMBALAGEM,
               SGMCONTROL.SGM_BUSCARULTIMOPRECO(@CODIGOCLIENTE, pcprodut.codprod)        AS ULTIMOPRECO,
               SUM(qt) AS QUANTIDADEFATURADA,
               ROUND((COUNT(DISTINCT(pcpedc.numped)) /
                     (SELECT COUNT(*)
                         FROM PCPEDC P
                        WHERE P.CODCLI = @CODIGOCLIENTE
                          AND P.DTCANCEL IS NULL
                          AND P.POSICAO NOT IN ('C'))) * 100,
                     2) AS PARTICIPACAO
                  FROM pcpedc
                 INNER JOIN pcpedi
                    ON pcpedc.numped = pcpedi.numped
                 INNER JOIN pcprodut
                    ON pcpedi.codprod = pcprodut.codprod
                  LEFT JOIN pcembalagem
                    ON pcembalagem.codprod = pcpedi.codprod
                   AND pcembalagem.codfilial = pcpedc.codfilial
                   AND pcembalagem.codauxiliar = pcpedi.codauxiliar
                 WHERE pcpedc.Codcli = @CODIGOCLIENTE
                   AND pcpedc.CODFILIAL = @CODIGOUNIDADE
                 group by pcprodut.codprod,
                          pcprodut.descricao,
                          NVL (pcembalagem.embalagem, pcprodut.embalagem)";

    public static string ResumoMes => @"
        SELECT 
               IDUSUARIO,
               VLFATURADOMES as valorFaturadoMes,
               CASE WHEN VLFATURADOMES > 0 THEN ROUND(((VLFATURADOMES - VLFATURADOMESANT)/VLFATURADOMES)*100,2) ELSE 0 END as percentualCrescimento,
               QTCLIPOSMES as quantidadeClientePositivoMes,
               CASE WHEN QTCLIPOSMES > 0 THEN ROUND(((QTCLIPOSMES - QTCLIPOSMESANT)/QTCLIPOSMES)*100,2) ELSE 0 END AS percentCrescimentoPositivacao,
               DECODE(QTPED,0,0,ROUND(VLFATURADOMES/QTPED,2)) as TicketMedio,
               ROUND((VLFATURADOMES / DIASUTEISPASSADOS) * DIASUTEISTOTAIS,2) AS PROJECAORESULTADO,
               (SELECT COUNT(*) FROM VSGM_CLIENTE_RCA R WHERE R.IDUSUARIO = M.IDUSUARIO)  AS QTCLICARTEIRA
          FROM VSGM_RESULTADO_MES M
          WHERE IDUSUARIO = @IDUSUARIOLOGADO";

    public static string RegionList => @"
        SELECT R.CODIGOREGIAO, UPPER(R.DESCRICAOREGIAO) AS DESCRICAOREGIAO
			  FROM VSGM_REGIAO R
	         WHERE EXISTS (SELECT * 
				             FROM VSGM_USUARIO_UNIDADE U
						    WHERE U.codigoUnidade = R.CODIGOUNIDADE
						      AND U.idusuario = @IDUSUARIO)
			   and exists (select * from vsgm_cliente c where c.REGIAOCLIENTE = r.CODIGOREGIAO
			   and exists (select * from vsgm_cliente_rca v
			 			    where v.CODIGOCLIENTE = c.CODIGOCLIENTE
			                  and v.IDUSUARIO = @IDUSUARIO)
			   )
		     ORDER BY R.DESCRICAOREGIAO";

    public static string SalesInsertValue => @"
        VALUES (@CODIGOPEDIDORCA, 
                @CODIGOPEDIDO, 
                @CODIGORCA, 
                '@NOMERCA', 
                @CODIGOCLIENTE, 
                '@FANTASIACLIENTE', 
                '@RAZAOSOCIALCLIENTE', 
                '@CNPJCPFCLIENTE', 
                SYS_EXTRACT_UTC(SYSTIMESTAMP), 
                SYS_EXTRACT_UTC(SYSTIMESTAMP), 
                '@NUMEROPEDIDOCLIENTE', 
                SYS_EXTRACT_UTC(SYSTIMESTAMP),
                '@CODIGOUNIDADEPEDIDO', 
                '@CODIGOUNIDADENFPEDIDO', 
                '@CODIGOUNIDADERETIRADAPEDIDO', 
                '@VALORFRETEPEDIDO', 
                '@CODIGOCOBRANCAPEDIDO', 
                '@CODIGOPLANPAGAMENTOPEDIDO', 
                '@CONDICAOVENDAPEDIDO', 
                '@OBSERVACAOPEDIDO', 
                '@OBSERVACAOENTREGAPEDIDO', 
                '@FRETEDESPACHOPEDIDO', 
                '@FRETEREDEDESPACHOPEDIDO',
                '@CODIGOFORNECEDORFRETEPEDIDO', 
                '@PRAZO1PEDIDO', 
                '@PRAZO2PEDIDO', 
                '@PRAZO3PEDIDO', 
                '@PRAZO4PEDIDO', 
                '@PRAZO5PEDIDO', 
                '@PRAZO6PEDIDO', 
                '@PRAZO7PEDIDO', 
                '@PRAZO8PEDIDO', 
                '@PRAZO9PEDIDO', 
                '@PRAZO10PEDIDO', 
                '@PRAZO11PEDIDO', 
                '@PRAZO12PEDIDO', 
                '@ORIGEMPEDIDO', 
                '@NUMEROPEDIDOCOMPRADOR', 
                '@POSICAOATUALPEDIDO', 
                '@SALDOATUALRCA', 
                '@TIPOPRIORIDADEENTREGAPEDIDO', 
                '@PERCDESCABATIMENTOPEDIDO', 
                '@CUSTOBONIFICACAOPEDIDO', 
                '@CODFORNECBONIFICACAOPEDIDO', 
                '@CODIGOBONIFICAOPEDIDO', 
                '@AGRUPAMENTOPEDIDO', 
                '@CODIGOENDERECOENTREGAPEDIDO', 
                '@ORCAMENTOPEDIDO', 
                '@VALORDESCONTOABATIMENTOPEDIDO', 
                '@VALORENTRADAPEDIDO', 
                '@STATUSPEDIDO', 
                '@TOTALITENSPEDIDO', 
                '@TOTALPEDIDO', 
                '@TOTPEDIDOCOMIMPOSTO', 
                '@OBSERVACAORETORNO', 
                '@SALDOVERBA', 
                '@QBPEDFRETE', 
                '@PERCENTUALFRETEOUTRAFILIAL', 
                '@CODIGO_FILIAL_PEDIDO_FRETE', 
                '@CODIGO_PRODUTO_PEDIDO_FRETE', 
                '@PRECO_PRODUTO_PEDIDO_FRETE', 
                '@CODIGO_PEDIDORCA_PEDIDO_FRETE', 
                '@CIDADECLIENTE', 
                '@TIPOEMISSAO', 
                '@QB_PEDIDO_PRE_VENDA', 
                '@CODIGO_PEDIDO_RCA_PEDIDO_PRE_VENDA', 
                '@CODIGOFILIALPEDIDOPRE_VENDA', 
                '@RETORNONUMEROPEDIDOERP', 
                '@RETORNOMOTIVOBLOQUEIO', 
                '@RETORNOVALORPEDIDO', 
                '@RETORNOVALORATENDIDO', 
                '@NUMEROPEDIDOVENDA', 
                '@DATAEMISSAOMAPA', 
                '@NUMEROPEDIDOERPORIGINAL', 
                '@COMISSAO', 
                '@PESO', 
                '@GEROUBRINDE', 
                '@CODIGOMOTORISTA', 
                '@NOMEMOTORISTA', 
                '@CELULARMOTORISTA', 
                SYS_EXTRACT_UTC(SYSTIMESTAMP), 
                '@STATUSPROCESSAMENTO', 
                SYS_EXTRACT_UTC(SYSTIMESTAMP), 
                '@MENSAGEMPROCESSAMENTO', 
                '@NOMEARQUIVOREMESSA', 
                '@IDUSUARIO', 
                '@ENDERECOCLIENTE')";
    public static string SalesInsert => @"INSERT INTO TABPEDIDO (CODIGOPEDIDORCA, CODIGOPEDIDO, CODIGORCA, NOMERCA, CODIGOCLIENTE, FANTASIACLIENTE, RAZAOSOCIALCLIENTE, CNPJCPFCLIENTE, DATAHORAABERTURAPEDIDO, DATAHORAFECHAMENTOPEDIDO, NUMEROPEDIDOCLIENTE, DATAENTREGAPEDIDO, CODIGOUNIDADEPEDIDO, CODIGOUNIDADENFPEDIDO, CODIGOUNIDADERETIRADAPEDIDO, VALORFRETEPEDIDO, CODIGOCOBRANCAPEDIDO, CODIGOPLANOPAGAMENTOPEDIDO, CONDICAOVENDAPEDIDO, OBSERVACAOPEDIDO, OBSERVACAOENTREGAPEDIDO, FRETEDESPACHOPEDIDO, FRETEREDESPACHOPEDIDO, CODIGOFORNECEDORFRETEPEDIDO, PRAZO1PEDIDO, PRAZO2PEDIDO, PRAZO3PEDIDO, PRAZO4PEDIDO, PRAZO5PEDIDO, PRAZO6PEDIDO, PRAZO7PEDIDO, PRAZO8PEDIDO, PRAZO9PEDIDO, PRAZO10PEDIDO, PRAZO11PEDIDO, PRAZO12PEDIDO, ORIGEMPEDIDO, NUMEROPEDIDOCOMPRADOR, POSICAOATUALPEDIDO, SALDOATUALRCA, TIPOPRIORIDADEENTREGAPEDIDO, PERCDESCABATIMENTOPEDIDO, CUSTOBONIFICACAOPEDIDO, CODFORNECBONIFICACAOPEDIDO, CODIGOBONIFICACAOPEDIDO, AGRUPAMENTOPEDIDO, CODIGOENDERECOENTREGAPEDIDO, ORCAMENTOPEDIDO, VALORDESCONTOABATIMENTOPEDIDO, VALORENTRADAPEDIDO, STATUSPEDIDO, TOTALITENSPEDIDO, TOTALPEDIDO, TOTALPEDIDOCOMIMPOSTO, OBSERVACAORETORNO, SALDOVERBA, QUEBRAPEDIDOFRETE, PERCENTUALFRETEOUTRAFILIAL, CODIGOFILIALPEDIDOFRETE, CODIGOPRODUTOPEDIDOFRETE, PRECOPRODUTOPEDIDOFRETE, CODIGOPEDIDORCAPEDIDOFRETE, CIDADECLIENTE, TIPOEMISSAO, QUEBRAPEDIDOPREVENDA, CODIGOPEDIDORCAPEDIDOPREVENDA, CODIGOFILIALPEDIDOPREVENDA, RETORNONUMEROPEDIDOERP, RETORNOMOTIVOBLOQUEIO, RETORNOVALORPEDIDO, RETORNOVALORATENDIDO, NUMEROPEDIDOVENDA, DATAEMISSAOMAPA, NUMEROPEDIDOERPORIGINAL, COMISSAO, PESO, GEROUBRINDE, CODIGOMOTORISTA, NOMEMOTORISTA, CELULARMOTORISTA, DATACADASTRO, STATUSPROCESSAMENTO, DATAPROCESSAMENTO, MENSAGEMPROCESSAMENTO, NOMEARQUIVOREMESSA, IDUSUARIO, ENDERECOCLIENTE)";

    public static string SalesUpdate => @"
        UPDATE TABPEDIDO SET CODIGOPEDIDO = @CAMPO, CODIGORCA = @CAMPO, NOMERCA = @CAMPO, CODIGOCLIENTE = @CAMPO, FANTASIACLIENTE = @CAMPO, RAZAOSOCIALCLIENTE = @CAMPO, CNPJCPFCLIENTE = @CAMPO, DATAHORAABERTURAPEDIDO = @CAMPO, DATAHORAFECHAMENTOPEDIDO = @CAMPO, NUMEROPEDIDOCLIENTE = @CAMPO, DATAENTREGAPEDIDO = @CAMPO, CODIGOUNIDADEPEDIDO = @CAMPO, CODIGOUNIDADENFPEDIDO = @CAMPO, CODIGOUNIDADERETIRADAPEDIDO = @CAMPO, VALORFRETEPEDIDO = @CAMPO, CODIGOCOBRANCAPEDIDO = @CAMPO, CODIGOPLANOPAGAMENTOPEDIDO = @CAMPO, CONDICAOVENDAPEDIDO = @CAMPO, OBSERVACAOPEDIDO = @CAMPO, OBSERVACAOENTREGAPEDIDO = @CAMPO, FRETEDESPACHOPEDIDO = @CAMPO, FRETEREDESPACHOPEDIDO = @CAMPO, CODIGOFORNECEDORFRETEPEDIDO = @CAMPO, PRAZO1PEDIDO = @CAMPO, PRAZO2PEDIDO = @CAMPO, PRAZO3PEDIDO = @CAMPO, PRAZO4PEDIDO = @CAMPO, PRAZO5PEDIDO = @CAMPO, PRAZO6PEDIDO = @CAMPO, PRAZO7PEDIDO = @CAMPO, PRAZO8PEDIDO = @CAMPO, PRAZO9PEDIDO = @CAMPO, PRAZO10PEDIDO = @CAMPO, PRAZO11PEDIDO = @CAMPO, PRAZO12PEDIDO = @CAMPO, ORIGEMPEDIDO = @CAMPO, NUMEROPEDIDOCOMPRADOR = @CAMPO, POSICAOATUALPEDIDO = @CAMPO, SALDOATUALRCA = @CAMPO, TIPOPRIORIDADEENTREGAPEDIDO = @CAMPO, PERCDESCABATIMENTOPEDIDO = @CAMPO, CUSTOBONIFICACAOPEDIDO = @CAMPO, CODFORNECBONIFICACAOPEDIDO = @CAMPO, CODIGOBONIFICACAOPEDIDO = @CAMPO, AGRUPAMENTOPEDIDO = @CAMPO, CODIGOENDERECOENTREGAPEDIDO = @CAMPO, ORCAMENTOPEDIDO = @CAMPO, VALORDESCONTOABATIMENTOPEDIDO = @CAMPO, VALORENTRADAPEDIDO = @CAMPO, STATUSPEDIDO = @CAMPO, TOTALITENSPEDIDO = @CAMPO, TOTALPEDIDO = @CAMPO, TOTALPEDIDOCOMIMPOSTO = @CAMPO, OBSERVACAORETORNO = @CAMPO, SALDOVERBA = @CAMPO, QUEBRAPEDIDOFRETE = @CAMPO, PERCENTUALFRETEOUTRAFILIAL = @CAMPO, CODIGOFILIALPEDIDOFRETE = @CAMPO, CODIGOPRODUTOPEDIDOFRETE = @CAMPO, PRECOPRODUTOPEDIDOFRETE = @CAMPO, CODIGOPEDIDORCAPEDIDOFRETE = @CAMPO, CIDADECLIENTE = @CAMPO, TIPOEMISSAO = @CAMPO, QUEBRAPEDIDOPREVENDA = @CAMPO, CODIGOPEDIDORCAPEDIDOPREVENDA = @CAMPO, CODIGOFILIALPEDIDOPREVENDA = @CAMPO, RETORNONUMEROPEDIDOERP = @CAMPO, RETORNOMOTIVOBLOQUEIO = @CAMPO, RETORNOVALORPEDIDO = @CAMPO, RETORNOVALORATENDIDO = @CAMPO, NUMEROPEDIDOVENDA = @CAMPO, DATAEMISSAOMAPA = @CAMPO, NUMEROPEDIDOERPORIGINAL = @CAMPO, COMISSAO = @CAMPO, PESO = @CAMPO, GEROUBRINDE = @CAMPO, CODIGOMOTORISTA = @CAMPO, NOMEMOTORISTA = @CAMPO, CELULARMOTORISTA = @CAMPO, DATACADASTRO = @CAMPO, STATUSPROCESSAMENTO = @CAMPO, DATAPROCESSAMENTO = @CAMPO, MENSAGEMPROCESSAMENTO = @CAMPO, NOMEARQUIVOREMESSA = @CAMPO, IDUSUARIO = @CAMPO, ENDERECOCLIENTE = @CAMPO
         WHERE CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string SalesDelete => @"
        DELETE TABPEDIDO WHERE CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string SalesInsertItens => @"
        INSERT INTO TABPEDIDOITENS (CODIGOPEDIDORCA, CODIGORCA, DATAHORAABERTURAPEDIDO, ITEM, CODIGOPRODUTO, DESCRICAOPRODUTO, QUANTIDADE, PRECOVENDAORIGINAL, PRECOVENDA, CODIGOBARRAS, QUANTIDADEFATURADA, BONIFICACAO, CODIGOCOMBO, CORTE, PERCENTUALDESCONTO, PERCENTUALDESCONTOBOLETO, SUGESTAO, CODIGOPEDIDO, PRECOVENDADESCONTO, VALORTOTAL, VALORTOTALCOMIMPOSTO, CODIGODESCONTO3306, DESCRICAODESCONTO3306, CODIGOPRODUTOPRINCIPAL, OBSERVACAORETORNO, CODIGOUNIDADERETIRA, TIPOENTREGA, CODIGODESCONTO561, DIFERENCAPRECO, SALDOVERBA, BASECREDDEBRCADESCONTO561, APLICAAUTOMATICODESCONTO561, PERCENTUALDESCONTO561, CODIGOAUXILIAREMBALAGEM, QUANTIDADEUNITARIAEMBALAGEM, UTILIZAVENDAPOREMBALAGEM, TIPOCARGAPRODUTO, EXIBECOMBOEMBALAGEM, ITEMNEGOCIADO, UNIDADEVENDA, TIPOESTOQUEPRODUTO, CODIGOREGIAO, PERCENTUALACRESCIMO, COMISSAO, PESO, VALORST, PRECOCOMST, VALORTOTALCOMST, NUMEROCARREGAMENTO, PERCENTUALBASERED, PERCENTUALICM, DATAVALIDADECAMPANHASHELF, PRECOCAMPANHASHELF, CODIGOCAMPANHASHELF, UNIDADEFRIOS) VALUES 
            (@CODIGOPEDIDORCA, 
            @CODIGORCA, 
            SYS_EXTRACT_UTC(SYSTIMESTAMP), 
            '@ITEM', 
            '@CODIGOPRODUTO', 
            '@DESCRICAOPRODUTO', 
            '@QUANTIDADE', 
            '@PRC_VENDA_ORIGINAL', 
            '@PRECOVENDA', 
            '@CODIGOBARRAS', 
            '@QTEFATURADA', 
            '@BONIFICACAO', 
            '@CODIGOCOMBO', 
            '@CORTE', 
            '@PERC_DESC', 
            '@PERC_DSC_BOLET', 
            '@SUGESTAO', 
            '@CODIGOPEDIDO', 
            '@PRC_VENDA_DESC', 
            '@VALORTOTAL', 
            '@VALOR_TOTAL_COM_IMPOSTO', 
            '@CODIGODESCONTO3306', 
            '@DESCRICAODESCONTO3306', 
            '@COD_PRD_PRINC', 
            '@OBSERVACAORETORNO', 
            '@CODIGOUNIDADERETIRA', 
            '@TIPOENTREGA', 
            '@CODIGODESCONTO561', 
            '@DIFERENCAPRECO', 
            '@SALDOVERBA', 
            '@BASECREDDEBRCADESCONTO561', 
            '@APLICAAUTOMATICODESCONTO561', 
            '@PERCENTUALDESCONTO561', 
            '@CODIGOAUXILIAREMBALAGEM', 
            '@QDEUNITARIAEMBALAGEM', 
            '@UTILIZAVENDAPOREMBALAGEM', 
            '@TIPOCARGAPRODUTO', 
            '@EXIBECOMBOEMBALAGEM', 
            '@ITNEGOC', 
            '@UNIDADEVENDA', 
            '@TIPOESTOQUEPRODUTO', 
            '@CODIGOREGIAO', 
            '@PERCENTUALACRESCIMO', 
            '@COMISSAO', 
            '@PESO', 
            '@VLR_ST', 
            '@PRC_COM_ST', 
            '@VL_TOT_COM_ST', 
            '@NUMEROCARREGAMENTO', 
            '@PERCENTUALBASERED', 
            '@PERCENTUALICM', 
            '@DATAVALIDADECAMPANHASHELF', 
            '@PRECOCAMPANHASHELF', 
            '@CODIGOCAMPANHASHELF', 
            '@UNIDADEFRIOS')";

    public static string SalesUpdateItens => @"
        UPDATE TABPEDIDO SET CODIGOPEDIDO = @CAMPO, CODIGORCA = @CAMPO, NOMERCA = @CAMPO, CODIGOCLIENTE = @CAMPO, FANTASIACLIENTE = @CAMPO, RAZAOSOCIALCLIENTE = @CAMPO, CNPJCPFCLIENTE = @CAMPO, DATAHORAABERTURAPEDIDO = @CAMPO, DATAHORAFECHAMENTOPEDIDO = @CAMPO, NUMEROPEDIDOCLIENTE = @CAMPO, DATAENTREGAPEDIDO = @CAMPO, CODIGOUNIDADEPEDIDO = @CAMPO, CODIGOUNIDADENFPEDIDO = @CAMPO, CODIGOUNIDADERETIRADAPEDIDO = @CAMPO, VALORFRETEPEDIDO = @CAMPO, CODIGOCOBRANCAPEDIDO = @CAMPO, CODIGOPLANOPAGAMENTOPEDIDO = @CAMPO, CONDICAOVENDAPEDIDO = @CAMPO, OBSERVACAOPEDIDO = @CAMPO, OBSERVACAOENTREGAPEDIDO = @CAMPO, FRETEDESPACHOPEDIDO = @CAMPO, FRETEREDESPACHOPEDIDO = @CAMPO, CODIGOFORNECEDORFRETEPEDIDO = @CAMPO, PRAZO1PEDIDO = @CAMPO, PRAZO2PEDIDO = @CAMPO, PRAZO3PEDIDO = @CAMPO, PRAZO4PEDIDO = @CAMPO, PRAZO5PEDIDO = @CAMPO, PRAZO6PEDIDO = @CAMPO, PRAZO7PEDIDO = @CAMPO, PRAZO8PEDIDO = @CAMPO, PRAZO9PEDIDO = @CAMPO, PRAZO10PEDIDO = @CAMPO, PRAZO11PEDIDO = @CAMPO, PRAZO12PEDIDO = @CAMPO, ORIGEMPEDIDO = @CAMPO, NUMEROPEDIDOCOMPRADOR = @CAMPO, POSICAOATUALPEDIDO = @CAMPO, SALDOATUALRCA = @CAMPO, TIPOPRIORIDADEENTREGAPEDIDO = @CAMPO, PERCDESCABATIMENTOPEDIDO = @CAMPO, CUSTOBONIFICACAOPEDIDO = @CAMPO, CODFORNECBONIFICACAOPEDIDO = @CAMPO, CODIGOBONIFICACAOPEDIDO = @CAMPO, AGRUPAMENTOPEDIDO = @CAMPO, CODIGOENDERECOENTREGAPEDIDO = @CAMPO, ORCAMENTOPEDIDO = @CAMPO, VALORDESCONTOABATIMENTOPEDIDO = @CAMPO, VALORENTRADAPEDIDO = @CAMPO, STATUSPEDIDO = @CAMPO, TOTALITENSPEDIDO = @CAMPO, TOTALPEDIDO = @CAMPO, TOTALPEDIDOCOMIMPOSTO = @CAMPO, OBSERVACAORETORNO = @CAMPO, SALDOVERBA = @CAMPO, QUEBRAPEDIDOFRETE = @CAMPO, PERCENTUALFRETEOUTRAFILIAL = @CAMPO, CODIGOFILIALPEDIDOFRETE = @CAMPO, CODIGOPRODUTOPEDIDOFRETE = @CAMPO, PRECOPRODUTOPEDIDOFRETE = @CAMPO, CODIGOPEDIDORCAPEDIDOFRETE = @CAMPO, CIDADECLIENTE = @CAMPO, TIPOEMISSAO = @CAMPO, QUEBRAPEDIDOPREVENDA = @CAMPO, CODIGOPEDIDORCAPEDIDOPREVENDA = @CAMPO, CODIGOFILIALPEDIDOPREVENDA = @CAMPO, RETORNONUMEROPEDIDOERP = @CAMPO, RETORNOMOTIVOBLOQUEIO = @CAMPO, RETORNOVALORPEDIDO = @CAMPO, RETORNOVALORATENDIDO = @CAMPO, NUMEROPEDIDOVENDA = @CAMPO, DATAEMISSAOMAPA = @CAMPO, NUMEROPEDIDOERPORIGINAL = @CAMPO, COMISSAO = @CAMPO, PESO = @CAMPO, GEROUBRINDE = @CAMPO, CODIGOMOTORISTA = @CAMPO, NOMEMOTORISTA = @CAMPO, CELULARMOTORISTA = @CAMPO, DATACADASTRO = @CAMPO, STATUSPROCESSAMENTO = @CAMPO, DATAPROCESSAMENTO = @CAMPO, MENSAGEMPROCESSAMENTO = @CAMPO, NOMEARQUIVOREMESSA = @CAMPO, IDUSUARIO = @CAMPO, ENDERECOCLIENTE = @CAMPO WHERE CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string SalesDeleteItens => @"
        DELETE TABPEDIDO WHERE CODIGOPEDIDORCA = @CODIGOPEDIDORCA";

    public static string NumeroPedidoRca => @"SELECT SGMCONTROL.SGM_BUSCARNUMEROPEDIDO(@IDUSUARIO) as NUMEROPEDIDORCA FROM DUAL";

    public static string tabServidor => @"select HOST, PORTA, USUARIO AS LICENCA from tabservidor where tiposervidor = 2";

    public static string TabObjetivoDiaInsert => @"INSERT INTO TABOBJETIVODIA (data, valormeta, codigosupervisor, codigounidade)
                                                   VALUES ('@DATA', @VALORMETA, @SUPERVISORID, @CODIGOUNIDADE)";

    public static string TabOjetivoDiaUpdate => @"update tabobjetivodia
                                                  set valormeta = @VALORMETA
                                                 where data = '@DATA'
                                                   and codigosupervisor = @SUPERVISORID
                                                   and codigounidade = @CODIGOUNIDADE ";
    public static string tabObjetivoDia => @"SELECT TABOBJETIVODIA.DATA,
                                                   TABOBJETIVODIA.VALORMETA,
                                                   nvl((SELECT SUM(P.VLATEND)
                                                      FROM PCPEDC P
                                                     WHERE P.DATA = TABOBJETIVODIA.DATA
                                                       AND P.CODFILIAL = TABOBJETIVODIA.CODIGOUNIDADE
                                                       AND P.DTCANCEL IS NULL
                                                       AND P.POSICAO IN ('L','M','P','B','F')
                                                       AND EXISTS (SELECT * 
                                                                     FROM TABUSUARIO U
                                                                    WHERE U.CODIGORCAUSUARIO = P.CODUSUR 
                                                                      AND U.IDSUPERIOR = TABOBJETIVODIA.CODIGOSUPERVISOR)),0) AS VALORVENDIDO
                                              FROM TABOBJETIVODIA
                                             WHERE TABOBJETIVODIA.DATA = TRUNC(SYSDATE)
                                               AND TABOBJETIVODIA.CODIGOUNIDADE = @CODIGOUNIDADE
                                               AND TABOBJETIVODIA.CODIGOSUPERVISOR = @SUPERVISORID
                                             GROUP BY TABOBJETIVODIA.DATA, 
                                                      TABOBJETIVODIA.CODIGOUNIDADE, 
                                                      TABOBJETIVODIA.CODIGOSUPERVISOR, 
                                                      TABOBJETIVODIA.VALORMETA";

    public static string ProdutoGrafico => @"SELECT 
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '01',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA01,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '02',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA02,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '03',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA03,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '04',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA04,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '05',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA05,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '06',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA06,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '07',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA07,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '08',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA08,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '09',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA09,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '10',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA10,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '11',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA11,
        SUM(DECODE(TO_CHAR(PCPEDI.DATA, 'MM'),
            '12',
            (NVL(PCPEDI.QT, 0) *
            (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
            NVL(PCPEDI.VLFRETE, 0))),
            0)) AS VLVENDA12,
        SUM(NVL(PCPEDI.QT, 0) *
          (NVL(PCPEDI.PVENDA, 0) + NVL(PCPEDI.VLOUTRASDESP, 0) +
          NVL(PCPEDI.VLFRETE, 0))) VLVENDATOT
          
      FROM PCPEDC,
        PCPEDI,
        PCCLIENT
        
      WHERE pcpedc.DATA between trunc(add_months(sysdate,-6),'month') and last_day(sysdate)
      AND PCPEDC.NUMPED = PCPEDI.NUMPED
      AND PCPEDC.CODCLI = PCCLIENT.CODCLI
      AND PCPEDC.DTCANCEL IS NULL
      AND PCPEDC.CODFILIAL = @CODIGOUNIDADE
      AND PCPEDC.CODCLI = @CODIGOCLIENTE
      AND PCPEDI.CODPROD = @CODIGOPRODUTO
      AND PCPEDC.POSICAO = 'F'
      AND PCPEDC.CONDVENDA IN (1, 2, 3, 7, 9, 14, 15, 17, 18, 19, 98)

      ORDER BY VLVENDATOT DESC";
}
