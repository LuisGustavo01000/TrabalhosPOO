# 🦆 Simulador de Patos - Jogo de Console em C#

Um jogo de console divertido para praticar **Programação Orientada a Objetos (POO)**, onde patos com habilidades especiais batalham entre si. O projeto explora **herança**, **interfaces** e **polimorfismo** em C#.

---

## 📚 Objetivo

Permitir que o jogador escolha um pato com habilidades únicas para enfrentar um pato inimigo controlado pela máquina. O vencedor é definido pela comparação das habilidades escolhidas em cada rodada.

---

## 🛠️ Conceitos Utilizados

- Herança
- Interfaces
- Polimorfismo
- Encapsulamento
- Estrutura modular
- Diagrama de Classes UML

---

## 🎮 Como Jogar

1. O jogador vê uma lista de patos disponíveis e suas habilidades.
2. Escolhe um pato para a batalha.
3. O sistema seleciona um pato inimigo aleatório.
4. Cada pato usa uma habilidade.
5. O resultado da rodada é exibido no console.

---

## 📁 Estrutura de Pastas

```plaintext
/TrabalhosPOO/
├── /src/                  # Código-fonte do jogo
│   ├── Program.cs         # Ponto de entrada
│   ├── /Models/           # Classes dos patos
│   ├── /Interfaces/       # Interfaces de habilidades
│   └── /Services/         # Lógica do jogo (menus, batalha, etc)
├── README.md              # Este arquivo
└── .gitignore
```

---

## ✅ Funcionalidades

- [x] Estrutura base com herança e interfaces
- [x] Exibição de lista de patos e habilidades
- [x] Sistema de batalha 
- [x] Definir campeão de acordo com Habilidade

---

## 👨‍💻 Créditos

Projeto criado por Luis Gustavo, Pablo Marques e Thiago Guilherme para a disciplina de Programação Orientada a Objetos - 3º Período ADS.

---

## 🚀 Requisitos

- .NET SDK 8.0 ou superior
- Visual Studio ou VS Code

---

## ▶️ Como Executar

```bash
git clone https://github.com/LuisGustavo01000/TrabalhosPOO.git
cd TrabalhosPOO/src/SimuladorDePatos
dotnet run
```

