create Database dbControleOrcamento

use dbControleOrcamento

CREATE TABLE [dbo].[Cliente] (
    [Cod_Cliente]        INT           IDENTITY (1, 1) NOT NULL,
    [Nome_Cliente]       VARCHAR (100) NULL,
    [CPF_Cliente]        VARCHAR (MAX) NULL,
    [RG_Cliente]         VARCHAR (MAX) NULL,
    [CEP_Cliente]        VARCHAR (15)  NULL,
    [Logradouro_Cliente] VARCHAR (100) NULL,
    [Numero_Cliente]     VARCHAR (10)  NULL,
    [Bairro_Cliente]     VARCHAR (100) NULL,
    [Cidade_Cliente]     VARCHAR (100) NULL,
    [Estado_Cliente]     VARCHAR (2)   NULL,
    [Telefone_Cliente]   VARCHAR (20)  NULL,
    [Celular_Cliente]    VARCHAR (20)  NULL,
    [Email_Cliente]      VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Cod_Cliente] ASC)
);

CREATE TABLE [dbo].[Empresa] (
    [Id_Empresa]                INT           IDENTITY (1, 1) NOT NULL,
    [RazaoSocial_Empresa]       VARCHAR (100) NULL,
    [NomeFantasia_Empresa]      VARCHAR (100) NULL,
    [CNPJ_Empresa]              VARCHAR (MAX) NULL,
    [InscricaoEstadual_Empresa] VARCHAR (MAX) NULL,
    [Logradouro_Empresa]        VARCHAR (100) NULL,
    [CEP_Empresa]               VARCHAR (10)  NULL,
    [Numero_Empresa]            VARCHAR (MAX) NULL,
    [Bairro_Empresa]            VARCHAR (50)  NULL,
    [Cidade_Empresa]            VARCHAR (100) NULL,
    [Estado_Empresa]            VARCHAR (2)   NULL,
    [Telefone_Empresa]          VARCHAR (16)  NULL,
    [Celular_Empresa]           VARCHAR (16)  NULL,
    [Email_Empresa]             VARCHAR (100) NULL,
    [LogoEmpresa_Empresa]       VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Empresa] ASC)
);

CREATE TABLE [dbo].[Usuario] (
    [Id_Usuario]        INT           IDENTITY (1, 1) NOT NULL,
    [Usuario_Login]     VARCHAR (30)  NOT NULL,
    [Senha_Login]        VARCHAR (MAX) NOT NULL,
    [DicaSenha_Login]   VARCHAR (30)  NULL,
    [PerguntaSeguranca] VARCHAR (MAX) NULL,
    [RespostaSeguranca] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC)
);


CREATE TABLE [dbo].[Orcamento] (
    [Cod_Orcamento]               INT             IDENTITY (1, 1) NOT NULL,
    [ValorPeças_Orcamento]        DECIMAL (18, 2) NULL,
    [ValorMaoObra_Orcamento]      DECIMAL (18, 2) NULL,
    [ValorTotal_Orcamento]        DECIMAL (18, 2) NULL,
    [DataPedido_Orcamento]        VARCHAR (10)    NULL,
    [EstimativaEntrega_Orcamento] VARCHAR (30)    NULL,
    [Situacao_Orcamento]          VARCHAR (20)    NULL,
    [ProdutoFinal_Orcamento]      VARCHAR (100)   NULL,
    [Cod_Cliente]                 INT             NULL,
    PRIMARY KEY CLUSTERED ([Cod_Orcamento] ASC),
    FOREIGN KEY ([Cod_Cliente]) REFERENCES [dbo].[Cliente] ([Cod_Cliente])
);

CREATE TABLE [dbo].[Peça] (
    [Cod_Peça]         INT             IDENTITY (1, 1) NOT NULL,
    [Descricao_Peça]   VARCHAR (100)   NULL,
    [Valor_Peça]       DECIMAL (18, 2) NULL,
    [Comprimento_Peça] VARCHAR (100)   NULL,
    [Unidade_Peça]     VARCHAR (2)     NULL,
    PRIMARY KEY CLUSTERED ([Cod_Peça] ASC)
);

CREATE TABLE [dbo].[ItensPeça] (
    [cod_Itens]        INT             IDENTITY (1, 1) NOT NULL,
    [Quantidade_Itens] INT             NULL,
    [Preço_Itens]      DECIMAL (18, 2) NULL,
    [Cod_Orcamento]    INT             NULL,
    [Cod_Peça]         INT             NULL,
    PRIMARY KEY CLUSTERED ([cod_Itens] ASC),
    FOREIGN KEY ([Cod_Peça]) REFERENCES [dbo].[Peça] ([Cod_Peça]),
    FOREIGN KEY ([Cod_Orcamento]) REFERENCES [dbo].[Orcamento] ([Cod_Orcamento])
);

CREATE TABLE ParcelaPagamento (
Cod_Parcela int PRIMARY KEY IDENTITY(1,1),
N_ParcelaPagamento int,
Vp_ParcelaPagamento decimal(18,2),
Dv_ParcelaPagamento varchar(10),
DP_ParcelaPagamento varchar(10),
Hp_ParcelaPagamento varchar(10),
Cod_Orcamento int,
FOREIGN KEY(Cod_Orcamento) REFERENCES Orcamento (Cod_Orcamento)
)

CREATE TABLE FormaPagamento (
Cod_FormaPagamento int PRIMARY KEY IDENTITY(1,1),
Descricao_FormaPagamento varchar(max),
Cod_Orcamento int,
FOREIGN KEY(Cod_Orcamento) REFERENCES Orcamento (Cod_Orcamento)
)