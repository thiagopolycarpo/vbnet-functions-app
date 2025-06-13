# 🧠 VB.NET Logical Functions Tester

Este projeto é uma coleção de funções utilitárias desenvolvidas em **VB.NET**, expostas via uma **API REST** em **C#** e consumidas por um frontend moderno com **React + Vite + TailwindCSS**.

---

## ✨ Tecnologias

- 💻 VB.NET — Lógica dos exercícios (modularizada)
- 🛠️ ASP.NET Core (.NET 8) — API REST em C#
- ⚛️ React + Vite — Frontend leve e moderno
- 🎨 TailwindCSS — Estilização visual
- 🧪 Postman/cURL — Para testes manuais

---

## 📁 Estrutura do Projeto

```
VBNetFunctionsSolution/
├── VBNetFunctions/           # Funções lógicas em VB.NET
├── VBNetFunctionsAPI/        # API C# que expõe as funções
│   └── Controllers/          # Controller central (FunctionsController.cs)
├── frontend/                 # Frontend em React + Vite
├── VBNetFunction.Tests/      # Automatic Tests using MSTest
└── README.md                 # Este arquivo
```

---

## 🚀 Como executar

### 1. Clonar o repositório
```bash
git clone https://github.com/thiagopolycarpo/vbnet-functions-app.git
cd VBNetFunctionsSolution
```

### 2. Backend (API)
```bash
cd VBNetFunctionsAPI
dotnet run
```

A API estará acessível em: `https://localhost:7175/api/functions`

### 3. Frontend
```bash
cd frontend
npm install
npm run dev
```

Frontend em: [http://localhost:5173](http://localhost:5173)


### 4. Tests
```bash
cd VBNetFunctions.Tests
dotnet test
```
---

## 🧪 Testar via Postman ou cURL

### Exemplo:
```bash
curl -X POST https://localhost:7175/api/functions/sum-even \
  -H "Content-Type: application/json" \
  -d '[2, 4, 6]' -k
```

Retorno esperado:
```json
{ "result": 12 }
```

---

## 🧩 Funções disponíveis

- `sum-even` — Soma dos números pares
- `max-number` — Maior número da lista
- `count-vowels` — Contar vogais em um texto
- `calculate-discount` — Aplicar desconto em valor
- `reverse-array` — Reverter lista de números
- `weighted-average` — Média ponderada
- `has-three-consecutive` — Verifica sequência crescente
- `first-repeated` — Primeiro número repetido
- `unique-numbers` — Números únicos da lista

---

## 📌 Observações

- A API usa certificado local HTTPS (`localhost`)
- O Vite está configurado com proxy para `/api`

---

## 📄 Licença

MIT. Livre para uso, estudo e modificação.
