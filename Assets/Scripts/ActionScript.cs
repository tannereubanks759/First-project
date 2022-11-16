using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ActionScript : MonoBehaviour
{
    public int[] numbers;
    public UnityEvent[] actions = new UnityEvent[0];
    public enum ExecutionType {Numbers, Actions, Both, None};
    public ExecutionType type;

    public void Play()
    {
        Debug.Log("Played Actions");
        if (type == ExecutionType.Both)
        {
            NumbersAndActions();
        }
        else if (type == ExecutionType.Numbers)
        {
            Numbers();
        }
        else if (type == ExecutionType.Actions)
        {
            Actions();
        }
    }

    void NumbersAndActions()
    {
        Debug.Log("Played Actions and numbers");

        //for (int i = 0; i < actions.Length; i++)
        for (int i = 0; i < actions.Length && i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
            actions[i].Invoke();
        }
    }

    void Numbers()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
            
        }
    }
    void Actions()
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Invoke();
        }
    }
}
