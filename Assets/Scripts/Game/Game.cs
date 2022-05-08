using System;
using System.Collections;

public class Game
{

    public readonly Bank bank = new Bank();
    public readonly Board board;
    public readonly Player[] players;

    private Player currentPlayer;

    public Player CurrentPLayer { get => currentPlayer; }

    Game(Player[] players, Board board, GameSettings settings) {
        //TODO implement settings
        this.players = players;
        this.board = board;
        currentPlayer = players[0];
    }

    public void begin() {
        
    }

    public void run() {
        
    }

    public bool isGameOver() {
        return false;
    }

}

public class GameSettings { 
   //TODO implement
}
