# Sistema de Gerenciamento de Tarefas

Este projeto é um **Sistema de Gerenciamento de Tarefas** desenvolvido com ASP.NET Core, que permite o gerenciamento de tarefas através de uma API REST.
O sistema permite realizar operações CRUD (Criar, Ler, Atualizar e Deletar) em tarefas, com funcionalidades adicionais como documentação via Swagger.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para desenvolvimento de aplicações web.
- **Entity Framework Core**: ORM para facilitar a interação com o banco de dados.
- **MySQL**: Banco de dados utilizado para armazenar as informações das tarefas.
- **Swagger**: Para documentação da API.

## Funcionalidades

- **Cadastro de Tarefas**: Permite criar, ler, atualizar e deletar tarefas com as seguintes informações:
  - Título
  - Descrição
  - Status (Pendente ou Concluída)
  - Prioridade (Baixa, Média ou Alta)

- **Documentação da API**: Utiliza Swagger para documentar e facilitar a visualização das rotas e parâmetros.

## Como Configurar o Projeto

### Pré-requisitos

- **.NET SDK** (versão 6.0 ou superior)
- **MySQL Server**: Um banco de dados MySQL configurado e acessível.
- **Visual Studio** ou **Visual Studio Code** para desenvolvimento.

### Passos para Configuração

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/ThiagoTenorio/ListaTarefas
