# JeuSerpentTDD
> :warning: **Verifier bien d'utiliser .NET sous la version 6.0 pour tester ce programme**

## Utilité
Ce programme permet d'apprendre le développement avec la méthodologie TDD (Test Driven Developpement), Il permet également de s'entrainer à réaliser du clean code.

## Principe
2 joueurs lancent un dé (1-6) au tour par tour, dans le but d'arriver à la case 50. S'ils dépassent 50, le joueur retourne directement à la case 25. Jusqu'à ce qu'un des deux gagne la partie.
Le jeu acclame le joueur par son nom à la fin.

## Bonus 
Selon les bonus proposés, j'ai réalisé les fonctionnalités suivantes :

- Si l'on tombe sur une case qui est un multiple de 10, le joueur peut rejouer une deuxième fois.
- Réalisé le jeu pour plus de deux joueurs.
- Permis la modification du nombre de cases du jeu à la création de celui-ci.

## Architecture du projet :

```
📦 Virex22/JeuDuSerpentTDD
├─ JeuDuSerpentTDD.sln
└─ JeuDuSerpentTDD
   ├─ Classes
   │  ├─ Dice.cs
   │  ├─ GameBoard.cs
   │  ├─ GameInit.cs
   │  └─ Player.cs
   ├─ JeuDuSerpentTDD.csproj
   ├─ JeuDuSerpentTDD.csproj.user
   ├─ Tests
   │  ├─ DiceTest.cs
   │  ├─ GameBoardTest.cs
   │  ├─ GameInitTest.cs
   │  ├─ GlobalTest.cs
   │  └─ PlayerTest.cs
   ├─ Usings.cs
   └─ program.cs
```
