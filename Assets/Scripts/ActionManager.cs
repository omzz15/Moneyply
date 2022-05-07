using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager
{
    //common actions
    public static readonly string k_OnAppOpen = "on app open";
    public static readonly string k_OnAppClose = "on app close";
    //these action are tied to objects with GameController
    public static readonly string k_OnAwake = "on awake";
    public static readonly string k_OnStart = "on start";
    public static readonly string k_OnUpdate = "on update";

    //variables
    Dictionary<string, Actions> allActions = new Dictionary<string, Actions>();

    public void AddAction(string trigger, string key, Action action)
    {
        try
        {
            allActions[trigger].AddAction(key, action);
        }
        catch (KeyNotFoundException)
        {
            allActions[trigger] = new Actions();
            AddAction(trigger, key, action);
        }
        catch (Exception e)
        {
            Debug.LogWarning("Exeption " + e + " thrown when addAction(" + trigger + ", " + key + ", " + action + ") was called!");
        }
    }

    public void AddAction(string trigger, Action action)
    {   
        try{
            allActions[trigger].AddAction(action);
        }
        catch (KeyNotFoundException){
            allActions[trigger] = new Actions();
            AddAction(trigger, action);
        }
        catch (Exception e) {
            Debug.LogWarning("Exeption " + e + " thrown when addAction(" + trigger + ", " + action + ") was called!");
        }
    }

    public void RunActions(string trigger) {
        try
        {
            allActions[trigger].RunAll();
        }
        catch (Exception e){
            Debug.LogWarning("Exeption " + e + " thrown when runActions(" + trigger + ") was called!");
        }
    }

    public void RunAction(string trigger, string key) {
        try
        {
            allActions[trigger].GetAction(key)();
        }
        catch (Exception e)
        {
            Debug.LogWarning("Exeption " + e + " thrown when runActions(" + trigger + ", " + key + ") was called!");
        }
    }

    public void ClearActions(string trigger)
    {
        try
        {
            allActions[trigger].ClearAll();
        }
        catch (Exception e)
        {
            Debug.LogWarning("Exeption " + e + " thrown when clearActions(" + trigger + ") was called!");
        }
    }
}

public class Actions
{
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    public void AddAction(string name, Action action)
    {
        //WARNING unprotected input!!
        actions.Add(name, action);
    }

    public void AddAction(Action action) {
        AddAction(actions.Count.ToString(), action);
    }

    public void RemoveAction(string key) {
        actions.Remove(key);
    }

    public Dictionary<string, Action> GetAllActions() {
        return actions;
    }

    public Action GetAction(string key) {
        return actions[key];
    }

    public void ClearAll(){
        actions.Clear();
    }

    public void RunAll()
    {
        foreach (Action action in actions.Values)
            action();
    }
}