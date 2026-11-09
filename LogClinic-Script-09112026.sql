
--**********************************************************************************************************
--**                                        SCRIPT DO BANCO DE DADOS - LOGCLINIC                          **
--**********************************************************************************************************                                                    
--** DATA DE CRIAÇÃO:  20/05/2026          - Criado o script com as tabelas com os campos básicos.        **
--** ATUALIZAÇÃO 1.0:  25/05/2026          - Atualizado as tabelas de médicos e pacientes.                **
--** ATUALIZAÇÃO 1.1:  26/10/2026          - Adição dos campos: tempo, cod, descricao no tabela servicos. **
--** ATUALIZAÇÃO 1.2:  09/11/2026(14:00)   - Atualização dos campos NÃO NULOS para NULOS                  **                                                                                                                             
--**********************************************************************************************************

-- CRIAR O BANCO DE DADOS
CREATE DATABASE LogClinic;

GO

-- HABILITA O BANCO DE DADOS
USE LogClinic;

GO

-- 1. TABELA OPERADOR (adiciona os u´suários do sistema)
CREATE TABLE operador (
    id INT IDENTITY(0,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    setor VARCHAR(20) NOT NULL,
    perfil VARCHAR(20) NOT NULL
);

 -- INSERIR OS DADOS DOS OPERADORES (PARA TESTE DO SISTEMA)
INSERT INTO operador (nome, cpf, usuario, senha, setor, perfil) VALUES
	('Administrador','12345678911','admin','1234','Administração','ADMIN'),
    ('Recepcionista','12345678912','recepcao','123','Recepção','RECEP');
    
-- 2. TABELA CONVENIO
CREATE TABLE convenio (
    id INT IDENTITY(0,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cobertura VARCHAR(100)NOT NULL
);

-- INSERIR UM CAONVÊNIO NA TABELA CONVENIO
INSERT INTO convenio (nome, cobertura) VALUES
    ('Particular','Particular'),
    ('Bradesco Saúde','Especial'),
    ('NotreDame','Ambulátorio'),
	('Amil','Nacional Sênior');


-- 3. TABELA PACIENTE
CREATE TABLE paciente (
    id INT IDENTITY(0,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    data_nascimento DATE NOT NULL,
    genero VARCHAR(20)NOT NULL,
    cpf VARCHAR(11) NOT NULL UNIQUE,
    rg VARCHAR(9),
    telefone VARCHAR(15),
    email VARCHAR(100),
    empresa VARCHAR(50),
    cep VARCHAR(8) NOT NULL,
    logradouro VARCHAR(100)NOT NULL,
    numero VARCHAR(15),
    complemento VARCHAR(100),
    bairro VARCHAR(100)NOT NULL,
    cidade VARCHAR(100)NOT NULL,
    estado VARCHAR(100)NOT NULL,
    uf VARCHAR(2)NOT NULL,
    convenio_id INT, -- Declarando a variável/coluna primeiro
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (convenio_id) REFERENCES convenio(id) -- Aplicando a FK no final
);


-- 4. TABELA CLINICA
CREATE TABLE clinica (
    id INT IDENTITY(0,1) PRIMARY KEY,
    cnpj VARCHAR(14) NOT NULL UNIQUE,
    nome VARCHAR(100)NOT NULL,
    logradouro VARCHAR(100)NOT NULL, -- Corrigido de lagradouro para logradouro
    bairro VARCHAR(100)NOT NULL,
    numero VARCHAR(15),
    complemento VARCHAR(100),
    cep VARCHAR(8)NOT NULL
);

-- 5. TABELA MEDICO
CREATE TABLE medico (
    id INT IDENTITY(0,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    crm VARCHAR(10) NOT NULL,
    crm_uf VARCHAR(2) NOT NULL,
    especialidade VARCHAR(100) NOT NULL,
    telefone VARCHAR(15),
    UNIQUE (crm, crm_uf) 
);

-- 6. ADICIONA TABELA DE SERVIÇOS E PREÇO
CREATE TABLE servicos(
id INT IDENTITY(0,1) PRIMARY KEY,
nome VARCHAR(100) NOT NULL,
valor DECIMAL(10,2) NOT NULL,
-- Alterações inseridas após a criação do formulário
tempo VARCHAR (15) NOT NULL,
cod VARCHAR(6) NOT NULL,
descricao VARCHAR(100)
);


---- INSERIR PARA TESTES SE PREFERIR CASO PODE INSERIR DIRETO NA APLICAÇÃO
--INSERT INTO servicos (nome,valor,tempo,cod,descricao) VALUES
--	('Consulta Geral','150.00','30','LOG501','Consulta com o clinico geral');
   


-- 7. TABELA CONSULTA (A tabela central que une todas as pontas)
CREATE TABLE consulta (
    id INT IDENTITY(0,1) PRIMARY KEY,
    paciente_id INT NOT NULL,
    clinica_id INT NOT NULL,
    medico_id INT NOT NULL,
    operador_id INT NOT NULL,
    convenio_id INT NOT NULL,
    servicos_id INT NOT NULL,
    data_consulta DATE NOT NULL,
    hora_consulta TIME NOT NULL,
    FOREIGN KEY (paciente_id) REFERENCES paciente(id),
    FOREIGN KEY (clinica_id) REFERENCES clinica(id),
    FOREIGN KEY (medico_id) REFERENCES medico(id),
    FOREIGN KEY (operador_id) REFERENCES operador(id),
    FOREIGN KEY (convenio_id) REFERENCES convenio(id),
    FOREIGN KEY (servicos_id) REFERENCES servicos(id)
 );




-- INSERIR OS DADOS DOS PACIENTES (PARA TESTES DO SISTEMA)
INSERT INTO paciente(nome, data_nascimento, genero, cpf, rg, telefone, email, empresa, cep, logradouro, numero, complemento, bairro, cidade, estado, uf, convenio_id, data_cadastro) VALUES
('Carlos Silva', '12/04/1985', 'Masculino', '11122233344', '123456789', '11987654321', 'carlos.silva@teste.com', 'Tech Corp', '01001000', 'Praça da Sé', '10', 'Sala 2', 'Sé', 'São Paulo', 'São Paulo', 'SP', 1, '20/10/2026'),
('Ana Oliveira', '25/08/1990', 'Feminino', '22233344455', '987654321', '21998887766', 'ana.oliveira@teste.com', 'Design Solutions', '20040002', 'Avenida Rio Branco', '156', 'Apto 1201', 'Centro', 'Rio de Janeiro', 'Rio de Janeiro', 'RJ', 2, '20/10/2026'),
('Roberto Santos', '03/11/1978', 'Masculino', '33344455566', '112233445', '31977778888', 'roberto.santos@teste.com', 'Logística Brasil', '30112010', 'Avenida Afonso Pena', '1500', NULL, 'Centro', 'Belo Horizonte', 'Minas Gerais', 'MG', 1, '20/10/2026'),
('Fernanda Costa', '17/02/1995', 'Feminino', '44455566677', '554433221', '41966665555', 'fernanda.costa@teste.com', 'Agência Criativa', '80010000', 'Rua XV de Novembro', '200', 'Loja 3', 'Centro', 'Curitiba', 'Paraná', 'PR', 3, '20/10/2026'),
('Lucas Mendes', '30/06/1988', 'Masculino', '55566677788', '998877665', '51955554444', 'lucas.mendes@teste.com', 'Construtora Sul', '90010001', 'Rua dos Andradas', '500', 'Andar 5', 'Centro Histórico', 'Porto Alegre', 'Rio Grande do Sul', 'RS', 0, '20/10/2026'),
('Marina Rocha', '10/12/1992', 'Feminino', '66677788899', '556677889', '71944443333', 'marina.rocha@teste.com', 'Turismo BA', '40020000', 'Avenida Sete de Setembro', '1000', NULL, 'Dois de Julho', 'Salvador', 'Bahia', 'BA', 2, '20/10/2026'),
('João Pereira', '05/09/1982', 'Masculino', '77788899900', '102030405', '81933332222', 'joao.pereira@teste.com', 'Comércio PE', '50010000', 'Avenida Conde da Boa Vista', '800', 'Bloco B', 'Boa Vista', 'Recife', 'Pernambuco', 'PE', 1, '20/10/2026'),
('Patrícia Lima', '22/03/1980', 'Feminino', '88899900011', '504030201', '85922221111', 'patricia.lima@teste.com', 'Moda CE', '60010000', 'Rua Barão do Rio Branco', '120', 'Apto 45', 'Centro', 'Fortaleza', 'Ceará', 'CE', 2, '20/10/2026'),
('Eduardo Alves', '14/07/1998', 'Masculino', '99900011122', '135792468', '61911110000', 'eduardo.alves@teste.com', 'Startup DF', '70040010', 'Esplanada dos Ministérios', '5', 'Sala 10', 'Zona Cívico-Administrativa', 'Brasília', 'Distrito Federal', 'DF', 0, '20/10/2026'),
('Camila Gomes', '08/01/1993', 'Feminino', '00011122233', '246813579', '92900009999', 'camila.gomes@teste.com', 'Bio Amazônia', '69010000', 'Avenida Eduardo Ribeiro', '300', NULL, 'Centro', 'Manaus', 'Amazonas', 'AM', 3, '20/10/2026');


SELECT * FROM consulta;
SELECT * FROM clinica;
SELECT * FROM medico;
SELECT * FROM operador;
SELECT * FROM convenio;
SELECT * FROM servicos;
SELECT * FROM paciente;
