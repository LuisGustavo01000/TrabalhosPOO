# 🦆 Batalha dos Patos - Jogo de Console em C#

Um jogo de console simples e divertido, desenvolvido como projeto de estudo da disciplina de **Programação Orientada a Objetos (POO)**. O objetivo é aplicar os conceitos de **herança**, **interfaces** e **polimorfismo** através de uma batalha entre patos com habilidades especiais.

---

## 📚 Objetivo do Projeto

Criar um jogo baseado em turnos onde o jogador escolhe um **pato lutador**, cada um com **atributos únicos** e **habilidades especiais**, para enfrentar um pato inimigo controlado pela máquina. Ganha quem reduzir a vida do oponente a **0 pontos**.

---

## 🛠️ Conceitos Aplicados

- ✅ Herança
- ✅ Interface
- ✅ Polimorfismo
- ✅ Encapsulamento
- ✅ Estrutura modular de código
- ✅ Diagrama de Classes UML

---

## 🎮 Como Jogar (em breve)

> ⚠️ A funcionalidade de batalha ainda está em desenvolvimento.

1. O jogador verá uma lista de patos disponíveis com seus atributos e habilidades.
2. Um pato será escolhido para a batalha.
3. A máquina escolherá um pato aleatoriamente.
4. A batalha ocorre por turnos (em desenvolvimento).

---

## 📁 Organização de Pastas

```plaintext
/TrabalhosPOO/
├── /src/               # Código-fonte do jogo
│   ├── Program.cs      # Ponto de entrada do programa
│   ├── /Models/        # Classes principais (Pato, tipos de pato)
│   ├── /Interfaces/    # Interfaces como IHabilidade
│   └── /Services/      # Lógica de jogo (turnos, batalha, etc)
├── /docs/              # Documentação e diagramas
│   └── DiagramaClasse.png
├── README.md           # Documentação do projeto
└──.gitignore

---

## Diagrama de Classes

(Imagem disponível em `docs/DiagramaClasse.png`)

---

## Próximas Etapas

- [x] Criar estrutura base com herança e interface
- [ ] Exibir lista de patos e seus atributos no console
- [ ] Implementar sistema de turnos
- [ ] Adicionar efeitos das habilidades
- [ ] Finalizar lógica de vitória/derrota

---

## Créditos

Projeto criado por Luis Gustavo, Pablo Marques e Thiago Guilherme para a disciplina de Programação Orientada a Objetos - 3º Período ADS.

---

## Requisitos

- .NET SDK 6.0 ou superior
- Visual Studio ou VS Code
- Terminal de console (cmd, bash, etc)

---

## Como Rodar

- git clone https://github.com/LuisGustavo01000/TrabalhosPOO.git
- cd batalha-dos-patos
- dotnet run

