# Funções Assíncronas do Entity Framework Core (C#)

Este README apresenta como utilizar as funções assíncronas do LINQ no Entity Framework Core para consultas e operações no banco de dados de forma **não bloqueante**.

---

## Consultas Assíncronas

Para consultas assíncronas, utilize o namespace:

```csharp
using Microsoft.EntityFrameworkCore;
```
## EXEMPLOS: 

```csharp
// Buscar todos os registros
var produtos = await _context.Produtos.ToListAsync();

// Filtrar com Where
var produtosCaros = await _context.Produtos
    .Where(p => p.Preco > 100)
    .ToListAsync();

// Buscar o primeiro registro
var primeiroProduto = await _context.Produtos.FirstOrDefaultAsync();

// Buscar por chave primária
var produto = await _context.Produtos.FindAsync(id);

// Verificar se existe algum registro
bool existe = await _context.Produtos.AnyAsync(p => p.Preco > 100);

// Contar registros
int total = await _context.Produtos.CountAsync();

// Obter o máximo valor
decimal maxPreco = await _context.Produtos.MaxAsync(p => p.Preco);
```
## Operações de Escrita (INSERT, UPDATE, DELETE):

```csharp
// Adicionar registro
await _context.Produtos.AddAsync(novoProduto);
await _context.SaveChangesAsync();

// Atualizar registro
_context.Produtos.Update(produto);
await _context.SaveChangesAsync();

// Remover registro
_context.Produtos.Remove(produto);
await _context.SaveChangesAsync();

##PAGINAÇÃO COM ASYNC 

var produtosPaginados = await _context.Produtos
    .OrderBy(p => p.Nome)
    .Skip(10)
    .Take(5)
    .ToListAsync();
```
## REFERENCIAS 
https://learn.microsoft.com/en-us/ef/core/?utm_source=chatgpt.com





















 

