using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    [SerializeField] FSM fsm = null;
    [SerializeField] GameObject owner = null;
    Color colorDebug = Color.black;

    public Color ColorDebug => colorDebug;

    public FSM FSM => fsm;
    public GameObject Owner => owner;


    public State(FSM _fsm, GameObject _owner)
    {
        fsm = _fsm;
        owner = _owner;
    }

    public  virtual void Enter()
    {
        
    }

    public virtual void Update()
    {
        
    }


    public virtual void Exit()
    {

    }
}
