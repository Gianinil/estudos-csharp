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

## Conteúdo

### 01-fundamentos

| Projeto | Assunto |
| --- | --- |
| `PrimeiroPrograma` | Estrutura mínima de um programa: `namespace`, classe e `Main` |
| `TiposPrimitivos` | `bool`, `char`, `byte`, `int`, `long` e o estouro do `byte` em 255 |
| `SaidaDeDados` | `Write` vs `WriteLine`, `ToString("F2")`, `CultureInfo` e interpolação |

### 02-poo

| Projeto | Assunto |
| --- | --- |
| `PrimeiraClasse` | Primeira classe com campos públicos e instanciação com `new` |

### 03-exercicios

| Projeto | Assunto |
| --- | --- |
| `ProdutosFormatacao` | Exercício juntando tipos, casas decimais e separador decimal |

Novos temas entram como pastas numeradas conforme eu avanço: coleções,
construtores e encapsulamento, herança, LINQ, tratamento de erros e testes.

## Convenções

- Um projeto por assunto, sempre executável com `dotnet run`.
- Pastas numeradas por tema, na ordem em que estudo.
- O código fica como foi escrito no estudo, inclusive os avisos do compilador
  que ainda não aprendi a tratar.

## Licença

[MIT](./LICENSE)
