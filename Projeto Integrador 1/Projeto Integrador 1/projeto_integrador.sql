-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04-Maio-2020 às 01:53
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projeto_integrador`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `abastecimentos`
--

CREATE TABLE `abastecimentos` (
  `id` int(11) NOT NULL,
  `viagem` int(11) DEFAULT NULL,
  `posto` int(11) NOT NULL,
  `veiculo` int(11) DEFAULT NULL,
  `motorista` int(11) DEFAULT NULL,
  `data` datetime NOT NULL,
  `cupom` varchar(20) DEFAULT NULL,
  `combustivel` int(1) NOT NULL,
  `hodometro` int(11) DEFAULT NULL,
  `status` int(1) NOT NULL,
  `litros` decimal(11,2) NOT NULL,
  `valor` decimal(11,2) NOT NULL,
  `total` decimal(11,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `tipo_cadastro` char(1) NOT NULL,
  `tipo_pessoa` char(2) NOT NULL,
  `cnpj` varchar(18) NOT NULL,
  `razao_social` varchar(150) NOT NULL,
  `nome_fantasia` varchar(150) DEFAULT NULL,
  `inscricao_municipal` varchar(15) DEFAULT NULL,
  `inscricao_estadual` varchar(15) DEFAULT NULL,
  `isento` tinyint(1) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `n` varchar(10) DEFAULT NULL,
  `bairro` varchar(60) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `ramal` varchar(10) DEFAULT NULL,
  `celular` varchar(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `observacoes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `financeiro`
--

CREATE TABLE `financeiro` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `tipo` int(1) NOT NULL,
  `referencia` int(11) DEFAULT NULL,
  `centro_custo` int(1) NOT NULL,
  `forma_pagamento` int(2) NOT NULL,
  `status` int(1) NOT NULL,
  `data_emissao` date NOT NULL,
  `data_vencimento` date NOT NULL,
  `valor` decimal(11,2) NOT NULL,
  `documento` varchar(30) DEFAULT NULL,
  `ocorrencia` int(1) NOT NULL,
  `qtd_parcelas` int(3) DEFAULT NULL,
  `parcelas` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`parcelas`)),
  `observacoes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `manutencoes`
--

CREATE TABLE `manutencoes` (
  `id` int(11) NOT NULL,
  `tipo` int(1) NOT NULL,
  `preventiva` int(1) DEFAULT NULL,
  `veiculo` int(11) NOT NULL,
  `status` int(1) NOT NULL,
  `motorista` int(11) NOT NULL,
  `data_agendada` datetime NOT NULL,
  `data_realizada` datetime DEFAULT NULL,
  `hodometro_agendado` int(11) NOT NULL,
  `hodometro_realizado` int(11) DEFAULT NULL,
  `observacoes` text DEFAULT NULL,
  `ordem_servico` varchar(20) DEFAULT NULL,
  `fornecedor` int(11) DEFAULT NULL,
  `mao_obra` varchar(20) DEFAULT NULL,
  `desconto` varchar(20) DEFAULT NULL,
  `acrecimo` varchar(20) DEFAULT NULL,
  `valor` varchar(20) DEFAULT NULL,
  `itens` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`itens`))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `motoristas`
--

CREATE TABLE `motoristas` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` int(12) DEFAULT NULL,
  `status` int(1) NOT NULL,
  `cnh` int(12) DEFAULT NULL,
  `vencimento` date DEFAULT NULL,
  `categoria` char(2) DEFAULT NULL,
  `sexo` char(1) NOT NULL,
  `estado_civil` int(1) NOT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `n` varchar(10) DEFAULT NULL,
  `bairro` varchar(60) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cargo` int(1) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `celular` varchar(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `multas`
--

CREATE TABLE `multas` (
  `id` int(11) NOT NULL,
  `veiculo` int(11) NOT NULL,
  `motorista` int(11) DEFAULT NULL,
  `gravidade` int(1) NOT NULL,
  `status` int(1) NOT NULL,
  `data_ocorrencia` date NOT NULL,
  `data_notificacao` date DEFAULT NULL,
  `data_vencimento` date DEFAULT NULL,
  `valor` decimal(11,2) DEFAULT NULL,
  `descricao` text DEFAULT NULL,
  `local` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `login` varchar(100) NOT NULL,
  `senha` varchar(32) NOT NULL,
  `acesso` int(1) NOT NULL DEFAULT 1,
  `ultimo_acesso` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `login`, `senha`, `acesso`, `ultimo_acesso`) VALUES
(1, 'igor.scheffer.ferreira@gmail.com', '091fd3e7ab19666a9126e520c3ea3dbc', 1, '2020-05-01 23:59:15'),
(2, 'projeto@unifeb.edu.br', '4840b8d5aa8b0023d4192360a01be117', 1, '2020-05-03 23:49:19');

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `id` int(11) NOT NULL,
  `frota` varchar(20) DEFAULT NULL,
  `placa` varchar(8) NOT NULL,
  `categoria` int(2) NOT NULL,
  `marca` int(2) NOT NULL,
  `carroceria` int(2) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `cor` int(2) NOT NULL,
  `combustivel` int(2) NOT NULL,
  `motorizacao` varchar(30) DEFAULT NULL,
  `renavam` varchar(20) DEFAULT NULL,
  `chassi` varchar(30) NOT NULL,
  `ano_fabricacao` int(4) NOT NULL,
  `ano_modelo` int(4) NOT NULL,
  `status` int(2) NOT NULL,
  `tara` varchar(20) DEFAULT NULL,
  `lotacao` varchar(20) DEFAULT NULL,
  `peso_bruto_total` varchar(20) DEFAULT NULL,
  `capacidade` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `viagens`
--

CREATE TABLE `viagens` (
  `id` int(11) NOT NULL,
  `remetente` int(11) NOT NULL,
  `destinatario` int(11) NOT NULL,
  `tomador` int(1) NOT NULL,
  `codigo_interno` varchar(10) DEFAULT NULL,
  `tipo_viagem` int(1) NOT NULL,
  `veiculo` int(11) NOT NULL,
  `reboque` int(11) NOT NULL,
  `motorista` int(11) NOT NULL,
  `saida_cidade` varchar(100) NOT NULL,
  `saida_uf` char(2) NOT NULL,
  `destino_cidade` varchar(100) NOT NULL,
  `destino_uf` char(2) NOT NULL,
  `status` int(1) NOT NULL,
  `data_saida` datetime DEFAULT NULL,
  `data_entrega` datetime DEFAULT NULL,
  `data_chegada` datetime DEFAULT NULL,
  `hodometro_saida` int(11) DEFAULT NULL,
  `hodometro_entrega` int(11) DEFAULT NULL,
  `hodometro_chegada` int(11) DEFAULT NULL,
  `hodometro_percorrido` int(11) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  `informacoes_complementares` text DEFAULT NULL,
  `cargas` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`cargas`)),
  `valor_cargas` decimal(11,2) DEFAULT NULL,
  `custos` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`custos`)),
  `valor_custos` decimal(11,2) DEFAULT NULL,
  `abastecimentos` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`abastecimentos`)),
  `valor_abastecimentos` decimal(11,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `abastecimentos`
--
ALTER TABLE `abastecimentos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `financeiro`
--
ALTER TABLE `financeiro`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `manutencoes`
--
ALTER TABLE `manutencoes`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `motoristas`
--
ALTER TABLE `motoristas`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `multas`
--
ALTER TABLE `multas`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `viagens`
--
ALTER TABLE `viagens`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `abastecimentos`
--
ALTER TABLE `abastecimentos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `financeiro`
--
ALTER TABLE `financeiro`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `manutencoes`
--
ALTER TABLE `manutencoes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `motoristas`
--
ALTER TABLE `motoristas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `multas`
--
ALTER TABLE `multas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `viagens`
--
ALTER TABLE `viagens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
