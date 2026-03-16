# Sistema de Controle de Clientes

Este projeto é uma aplicação console desenvolvida em C# como parte de uma atividade educacional da Turma de Desenvolvimento Full Stack do SENAI da UC12-Codificação para Back-End - CTMSP_DDF_QO_FULLST_251T01_CBEND_QUA.459.028 (SA2 - Atividade 1). O sistema permite o cadastro simplificado de clientes, diferenciando entre Pessoas Físicas e Pessoas Jurídicas, e realiza o cálculo de impostos sobre um valor de compra informado.

## 🚀 Funcionalidades

- **Cadastro de Clientes**: Registro de nome e endereço.
- **Pessoa Física**:
    - Suporte a CPF e RG.
    - Cálculo de imposto de 10% sobre o valor da compra.
- **Pessoa Jurídica**:
    - Suporte a CNPJ e Inscrição Estadual (IE).
    - Cálculo de imposto de 20% sobre o valor da compra.
- **Interface Console**: Interação amigável via terminal para entrada de dados e exibição de resultados.

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET

## 📋 Pré-requisitos

Para executar este projeto, você precisará ter instalado em sua máquina:

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior recomendada).

## 🔧 Como Executar

1. Clone o repositório ou baixe os arquivos do projeto.
2. Abra o terminal na pasta raiz do projeto.
3. Execute o comando abaixo para iniciar a aplicação:

```bash
dotnet run
```

4. Siga as instruções no console para informar os dados do cliente e o valor da compra.

## 📁 Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplicação e lógica de interface.
- `Clientes.cs`: Classe base com propriedades e métodos comuns.
- `Pessoa_Fisica.cs`: Especialização para clientes pessoa física.
- `Pessoa_Juridica.cs`: Especialização para clientes pessoa jurídica e sobrescrita do cálculo de imposto.

---
Desenvolvido como parte do curso SENAI.
