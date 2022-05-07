using UnityEngine;

public class GameController : MonoBehaviour
{
    //general
    private static ActionManager actionManager = new ActionManager();

    public static ActionManager GetActionManager()
    {
        return actionManager;
    }

    public static void closeApp() {
        Application.Quit();
    }

    void Awake()
    {
        actionManager.RunActions(ActionManager.k_OnAwake);
    }

    void Start()
    {
        actionManager.RunActions(ActionManager.k_OnStart);
    }

    void Update()
    {
        actionManager.RunActions(ActionManager.k_OnUpdate);
    }

    void OnApplicationQuit()
    {
        actionManager.RunActions(ActionManager.k_OnAppClose);
    }
}
