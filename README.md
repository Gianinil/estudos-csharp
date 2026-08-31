# Estudos de C#

Repositório onde registro meu aprendizado em C# e .NET. Cada pasta é um tema,
com projetos pequenos e executáveis que resolvem um problema específico.

## Como rodar

Requer o [.NET SDK 10](https://dotnet.microsoft.com/download) ou superior.

```bash
git clone https://github.com/Gianinil/estudos-csharp.git
cd estudos-csharp
dotnet run --project 01-fundamentos/PrimeiroPrograma
```

Para abrir tudo de uma vez no Visual Studio ou no Rider, use `EstudosCSharp.slnx`.
Para compilar todos os projetos de uma vez: `dotnet build EstudosCSharp.slnx`.

Vários projetos leem do teclado com `Console.ReadLine()` e esperam número com
ponto como separador decimal (`InvariantCulture`).

## Conteúdo

### 01-fundamentos

Na ordem em que estudei.

| Projeto | Assunto |
| --- | --- |
| `PrimeiroPrograma` | Estrutura mínima de um programa: `namespace`, classe e `Main` |
| `TiposPrimitivos` | `bool`, `char`, `byte`, `int`, `long` e o estouro do `byte` em 255 |
| `SaidaDeDados` | `Write` vs `WriteLine`, `ToString("F2")`, `CultureInfo` e interpolação |
| `Projeto4` | Operadores de atribuição (`+=`, `-=`, `*=`) e incremento pré e pós-fixado |
| `Projeto5` | Conversão implícita, casting explícito e divisão inteira vs real |
| `OperadoresAritimeticos` | Precedência, `%`, divisão inteira vs real e fórmula de Bhaskara |
| `ConsoleApp1` | Entrada de dados: `int.Parse`, `char.Parse`, `double.Parse` com `CultureInfo` e leitura de vários valores na mesma linha com `Split` |
| `operadoresComparativos` | `==`, `!=`, `>`, `<`, `>=`, `<=` guardados em variáveis `bool` |
| `operadoresLogicos` | `&&`, `\|\|` e `!` combinando condições |
| `estruturaCondicional` | `if`, `else if` e `else`: número par ou ímpar e saudação pelo horário |
| `funcoes` | Em andamento — projeto recém-criado, ainda no template padrão |

### 02-poo

| Projeto | Assunto |
| --- | --- |
| `PrimeiraClasse` | Primeira classe (`carro`) com campos públicos e instanciação com `new` |

### 03-exercicios

| Projeto | Assunto |
| --- | --- |
| `ProdutosFormatacao` | Exercício juntando tipos, casas decimais e separador decimal |
| `Entrada de dados` | Exercício de leitura pelo teclado: nome, inteiro e `double`, mais três valores na mesma linha, reimpressos formatados |
| `ex03` | Classe `Funcionarios` com `nome` e `salario`: lê dois funcionários e imprime a média dos salários com `F2` |
| `ex04` | Classe `Pessoa` com `nome` e `idade`: lê duas pessoas e diz qual é a mais velha |

### Projeto solto na raiz

| Projeto | Assunto |
| --- | --- |
| `SaidaDeDados` (raiz) | Apesar do nome, é sobre **entrada** de dados: várias leituras com `ReadLine` e quebra de uma linha com `Split`. Nome herdado do Visual Studio, ainda a mover para `01-fundamentos` |

Novos temas entram como pastas numeradas conforme eu avanço: funções e métodos,
coleções, construtores e encapsulamento, herança, LINQ, tratamento de erros e
testes.

## Convenções

- Um projeto por assunto, sempre executável com `dotnet run`.
- Pastas numeradas por tema, na ordem em que estudo.
- Projeto novo nasce solto na raiz (criado pelo Visual Studio) e depois é movido
  para a pasta do tema e registrado em `EstudosCSharp.slnx`.
- O código fica como foi escrito no estudo, inclusive os avisos do compilador
  que ainda não aprendi a tratar.

## Licença

[MIT](./LICENSE)
