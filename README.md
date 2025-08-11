# 🦆 Simulador de Patos - Jogo de Console em C#

Um jogo de console divertido para praticar **Programação Orientada a Objetos (POO)**, onde patos com habilidades especiais batalham entre si. O projeto explora **herança**, **interfaces** e **polimorfismo** em C#.

---

## ▶️ Como Executar

### Executando a versão Console

```bash
git clone https://github.com/LuisGustavo01000/TrabalhosPOO.git
cd TrabalhosPOO/src/SimuladorDePatos
dotnet run
```

---

### Executando a versão Windows Forms

> **Pré-requisito:** É necessário ter o SDK do .NET 8.0 e o Windows instalado.

1. Abra o Visual Studio (recomendado) ou VS Code.
2. Navegue até a pasta `src/Simulador-de-Patos-Forms/Simulador-de-Patos`.
3. No Visual Studio, abra o arquivo de solução `Simulador-de-Patos.sln` e defina o projeto `Simulador-de-Patos` como projeto de inicialização. Clique em **Iniciar** (F5) para rodar a aplicação gráfica.

   **Ou pelo terminal:**

   ```bash
   cd src/Simulador-de-Patos-Forms/Simulador-de-Patos
   dotnet run
   ```

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

## Diagrama de Classe

O projeto utiliza uma arquitetura baseada em herança, interfaces e princípios SOLID para garantir modularidade e flexibilidade. Veja abaixo o diagrama de classes UML que representa a estrutura principal do simulador:

![Diagrama de Classe](src/DiagramaUML.png)

## 📁 Estrutura de Pastas

```plaintext
/TrabalhosPOO/
├── /src/
│   ├── README.md                # Documentação detalhada do projeto
│   ├── DiagramaUML.png          # Imagem do diagrama de classes
│   ├── /Simulador-de-Patos-Forms/
│   │   ├── README_SOLID_DESIGN.md   # Análise SOLID e Design Patterns
│   │   ├── /Simulador-de-Patos/
│   │   │   ├── /Models/         # Classes dos patos (ex: Duck, DizzyDuck...)
│   │   │   ├── /Interfaces/     # Interfaces de habilidades (ex: IQuackable...)
│   │   │   ├── /Services/       # Lógica do jogo (menus, fábrica, batalha)
│   │   │   └── ...
│   └── /SimuladorDePatos/       # Versão console do simulador
│       ├── /Models/
│       ├── /Interfaces/
│       ├── /Services/
│       └── ...
├── README.md                    # Este arquivo (resumo geral)
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



