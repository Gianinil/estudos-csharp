# Estudos de C#

Repositório onde registro meu aprendizado em C# e .NET. Cada pasta é um tema,
com projetos pequenos e executáveis que resolvem um problema específico.

## Como rodar

Requer o [.NET SDK 10](https://dotnet.microsoft.com/download) ou superior.

```bash
git clone https://github.com/Gianinil/estudos-csharp.git
cd estudos-csharp
dotnet run --project 01-fundamentos/Fundamentos
```

Para abrir tudo de uma vez no Visual Studio ou no Rider, use `EstudosCSharp.slnx`.

## Estrutura

| Pasta | Conteúdo |
| --- | --- |
| `01-fundamentos` | Tipos, variáveis, controle de fluxo, métodos |

Novos temas entram como pastas numeradas conforme eu avanço: coleções, POO,
LINQ, async/await, tratamento de erros, acesso a dados e testes.

## Convenções

- Um projeto por assunto, sempre executável com `dotnet run`.
- Comentários explicam o *porquê* do código, não o óbvio.
- Cada projeto tem um `README.md` curto quando o tema exige contexto.

## Licença

[MIT](./LICENSE)
