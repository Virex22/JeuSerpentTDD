﻿using JeuDuSerpentTDD.Classes;

List<Player> players = GameInit.getPlayers();

GameBoard gameBoard = new GameBoard(players);
Player winner = gameBoard.StartGame();
Console.WriteLine($"Le gagnant est {winner.Name}");