using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition
{
    State nextState = null;
    Func<bool> condition = null;

    public State NextState => nextState;
    public Func<bool> Condition => condition;

    public Transition(Func<bool> _condition , State _nextState)
    {
        nextState = _nextState;
        condition = _condition;
    }
}
