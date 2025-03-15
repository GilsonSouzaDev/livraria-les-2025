SET FOREIGN_KEY_CHECKS = 0;

-- 1. Criar Tabela de Clientes (base para outras tabelas)
CREATE TABLE Clientes (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    CodigoCliente VARCHAR(20) UNIQUE NOT NULL,  
    Genero VARCHAR(20) NOT NULL,  
    Nome VARCHAR(255) NOT NULL, 
    DataNascimento VARCHAR(10) NOT NULL, 
    CPF VARCHAR(14) UNIQUE NOT NULL, 
    Email VARCHAR(255) UNIQUE NOT NULL,
    Pontuacao INT, 
    Ranking INT,  
    Ativo BOOLEAN DEFAULT TRUE  
);

-- 2. Criar Tabela de Telefones (depende de Clientes)
CREATE TABLE TelefonesCliente (
    TelefoneID INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT NOT NULL,
    TipoTelefone VARCHAR(20) NOT NULL, 
    DDD VARCHAR(3) NOT NULL,
    Numero VARCHAR(20) NOT NULL,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID) ON DELETE CASCADE
);

-- 3. Criar Tabela de Endereços (depende de Clientes)
CREATE TABLE EnderecosCliente (
    EnderecoID INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT NOT NULL,
    NomeEndereco VARCHAR(50) NOT NULL,  
    TipoResidencia VARCHAR(50) NOT NULL, 
    TipoLogradouro VARCHAR(50) NOT NULL, 
    Logradouro VARCHAR(255) NOT NULL, 
    Numero VARCHAR(20) NOT NULL, 
    Bairro VARCHAR(100) NOT NULL, 
    CEP VARCHAR(10) NOT NULL, 
    Cidade VARCHAR(100) NOT NULL, 
    Estado VARCHAR(2) NOT NULL, 
    Pais VARCHAR(50) NOT NULL, 
    Observacoes TEXT,  
    UsoCobranca BOOLEAN DEFAULT FALSE, 
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID) ON DELETE CASCADE
);

-- 4. Criar Tabela de BandeirasCartao (independente)
CREATE TABLE BandeirasCartao (
    BandeiraID INT AUTO_INCREMENT PRIMARY KEY,
    NomeBandeira VARCHAR(50) UNIQUE NOT NULL
);

-- 5. Criar Tabela de Cartões de Crédito (depende de Clientes e BandeirasCartao)
CREATE TABLE CartoesCreditoCliente (
    CartaoCreditoClienteID INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT NOT NULL,
    BandeiraID INT NOT NULL,
    NumeroCartao VARCHAR(255) NOT NULL,  
    NomeNoCartao VARCHAR(255) NOT NULL, 
    CodigoSeguranca VARCHAR(10) NOT NULL, 
    Preferencial BOOLEAN DEFAULT FALSE, 
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID) ON DELETE CASCADE,
    FOREIGN KEY (BandeiraID) REFERENCES BandeirasCartao(BandeiraID) ON DELETE CASCADE
);




