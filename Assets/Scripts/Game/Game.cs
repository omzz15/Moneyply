using System;
using System.Collections;

public class Game
{
    public readonly Bank bank = new Bank();
    public readonly Player[] players;
    public readonly Tile[] tiles;

    int currentPlayer;
    int[] currentDice;

    public Player CurrentPlayer { get => players[currentPlayer]; }
    public Tile CurrentTile { get => tiles[CurrentPlayer.Location]; }

    Game(Player[] players, Tile[] tiles, GameSettings settings) {
        this.players = players;
        this.tiles = tiles;
        currentPlayer = 0;
    }

    public void begin() {
        
    }

    public void run() {
        if (currentPlayer >= players.Length)
            currentPlayer = 0;
        Player curr = players[currentPlayer];
        currentDice = rollDice();
        int newLocation = curr.Location + currentDice[0] + currentDice[1];
        curr.Location = newLocation % tiles.Length;
        
        Tile currTile = tiles[curr.Location];

    }

    public bool isGameOver() {
        return false;
    }

    private int[] rollDice() {
        Random r = new Random();
        return new int[] { r.Next(1,6), r.Next(1,6)};
    }
}

public class GameSettings { 
   
}
