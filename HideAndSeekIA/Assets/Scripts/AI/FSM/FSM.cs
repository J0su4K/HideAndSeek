using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FSM
{

    [SerializeField] State currentState = null;
    Dictionary<State , List<Transition>> transitions = new Dictionary<State , List<Transition>>();

    public void SetNextState(State _state)
    {
        if (currentState != null)
            currentState.Exit();
        currentState = _state;
        currentState.Enter();
    }

    public void AddTransition(State _from, State _to, Func<bool> _condition)
    {
        if (!transitions.ContainsKey(_from))
        {
            transitions[_from] = new List<Transition>();

        }

        transitions[_from].Add(new(_condition, _to));
    }


    public void Update()
    {
        if (currentState == null) return;
        foreach (Transition _transition in transitions.GetValueOrDefault(currentState, new List<Transition>()))
        {
            if (_transition.Condition()) //Si la condition est valide
            {
                SetNextState(_transition.NextState);
                return;
            }
        }
        currentState.Update();
    }
}
