# ScreenSound 5 — persistência em C#

Repositório de estudo do curso de .NET sobre persistência com Entity Framework Core. O código usa .NET 7, o provedor SQL Server do EF Core e um contexto com artistas. `Banco/ArtistaDAO.cs` reúne operações de listar, adicionar, atualizar e remover artistas.

## Persistência

`Banco/ScreenSoundContext.cs` aponta para uma instância SQL Server LocalDB e autenticação integrada. O exemplo depende desse ambiente de banco; não basta iniciar o console em uma máquina sem a instância e a estrutura esperadas.

O roteiro de aulas abaixo registra os tópicos do curso. A implementação deste repositório usa um DAO específico de artistas e não inclui uma pasta de migrations; os tópicos do roteiro abrangem mais do que esse código.

## Roteiro do curso

## ScreenSound5

### Descrição
Curso de .NET: persistindo dados com Entity Framework Core

### Tópicos das aulas

#### Aula 1: Conectando SQL Server à Aplicação
- Configuração da conexão com o SQL Server.
- Estabelecimento da comunicação entre a aplicação e o banco de dados.

#### Aula 2: Introdução ao Entity Framework Core
- Conceitos de ORM (Object-Relational Mapping).
- Implementação inicial do Entity Framework no projeto.

#### Aula 3: Uso de Generics
- Aplicação do conceito de Generics para otimização do código.
- Criação de classes genéricas para operações CRUD.

#### Aula 4: Trabalhando com Migrations
- Conceito e importância das Migrations.
- Gerenciamento de versões do banco de dados através de Migrations.

#### Aula 5: Relacionamento entre Tabelas
- Aprofundamento nos relacionamentos entre tabelas (One-to-Many, Many-to-Many).
- Implementação de relacionamentos no Entity Framework.
- Finalização da aplicação ScreenSound com persistência de dados.
