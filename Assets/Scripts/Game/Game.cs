using System.Collections.Generic;

public class Game
{
    public readonly Bank bank = new Bank();
    public readonly Board board;
    public readonly Player[] players;

    private Player currentPlayer;

    private List<PlayAction> possiblePlayActions = new List<PlayAction>();
    private PlayAction selectedPlayAction;
    private bool playDone = false;

    public Player CurrentPLayer { get => currentPlayer; }
    public Tile CurrentTile { get => board.GetTile(currentPlayer); }
    public bool TurnOver { get => playDone; }

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

    /**
     * moves the player with a new dice roll
     */
    public void MovePlayer()
    {
        MovePlayer(CurrentPLayer, board.dice.getNewRoll());
    }

    public void MovePlayer(Player player, int spaces)
    {
        if (spaces < 1) return;//just some safety for more robustness

        int end = player.Location + spaces;

        player.Location++;

        while (player.Location < end)
        {
            board.GetTile(player).OnPass(this);
            player.Location++;

            if (player.Location >= board.GetTileLength())
            {
                player.Location = 0;
                end -= board.GetTileLength();
            }
        }

        board.GetTile(player).OnLand(this);
    }

    public void AddPlayAction(PlayAction action) {
        possiblePlayActions.Add(action);
    }

    public List<PlayAction> GetPlayActions() {
        return possiblePlayActions;
    }

    public void SelectPlayAction(int index) {
        selectedPlayAction = possiblePlayActions[index];
    }

    public void SelectPlayAction(PlayAction action) {
        if (action == null) return; //will cause lots of issues

        selectedPlayAction = action;
    }
}

public class GameSettings { 
   //TODO implement
}
