-- Verifica e cria o banco de dados (se não existir)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'DataBaseXYZ')
BEGIN
    CREATE DATABASE DataBaseXYZ;
END
GO -- Separa o batch após criação do banco

USE DataBaseXYZ; -- Define o contexto do banco
GO -- Separa o batch após USE

-- Criação da tabela Transacoes
CREATE TABLE Transacoes (
    Id_Transacao INT IDENTITY(1,1) PRIMARY KEY,
    Numero_Cartao CHAR(16) NOT NULL,
    Valor_Transacao DECIMAL(18,2) CHECK (Valor_Transacao > 0),
    Data_Transacao DATETIME NOT NULL DEFAULT GETDATE(),
    Descricao VARCHAR(255),
    Status_Transacao VARCHAR(20) CHECK (Status_Transacao IN ('Aprovada', 'Pendente', 'Cancelada'))
);
GO -- Separa a criação da tabela

-- Criação da stored procedure
CREATE OR ALTER PROCEDURE dbo.usp_CalcularTransacoes
    @Data_Inicial DATETIME,
    @Data_Final DATETIME,
    @Status_Transacao VARCHAR(20)
AS
BEGIN
    SELECT 
        Numero_Cartao,
        SUM(Valor_Transacao) AS Valor_Total,
        COUNT(*) AS Quantidade_Transacoes,
        Status_Transacao
    FROM Transacoes
    WHERE Data_Transacao BETWEEN @Data_Inicial AND @Data_Final
      AND Status_Transacao = @Status_Transacao
    GROUP BY Numero_Cartao, Status_Transacao;
END;
GO -- Separa a criação da procedure

-- Criação da função escalar
CREATE OR ALTER FUNCTION dbo.fn_CategoriaValor(@Valor DECIMAL(18,2))
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @Categoria VARCHAR(20);

    SELECT @Categoria = CASE
        WHEN @Valor > 2000 THEN 'Premium'
        WHEN @Valor BETWEEN 1000 AND 2000 THEN 'Alta'
        WHEN @Valor BETWEEN 500 AND 999.99 THEN 'Média'
        ELSE 'Baixa'
    END;

    RETURN @Categoria;
END;
GO -- Separa a criação da função escalar

-- Criação da função table-valued
CREATE OR ALTER FUNCTION dbo.tvf_TransacoesCategorizadas
(
    @Data_Inicial DATETIME,
    @Data_Final DATETIME
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        t.*,
        dbo.fn_CategoriaValor(t.Valor_Transacao) AS Categoria
    FROM Transacoes t
    WHERE t.Data_Transacao BETWEEN @Data_Inicial AND @Data_Final
);
GO -- Separa a criação da TVF

-- Criação da view
CREATE OR ALTER VIEW dbo.vw_ConsolidadoFinanceiro
AS
SELECT 
    Numero_Cartao,
    SUM(Valor_Transacao) AS TotalTransacoes,
    COUNT(*) AS QuantidadeTransacoes
FROM Transacoes
GROUP BY Numero_Cartao;
GO -- Separa a criação da view