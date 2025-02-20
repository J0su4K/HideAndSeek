using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocationState : State
{
    MovementAIComponent movementAIComponent = null;


    public MovementAIComponent MovementAIComponent => movementAIComponent;

    public MoveToLocationState(FSM _fsm, GameObject _owner) : base(_fsm, _owner)
    {
          
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enter in Move State");
        Init();
    }

    public override void Update()
    {
        movementAIComponent.MoveTo();
    }

    public override void Exit()
    {

    }

    void Init()
    {
        movementAIComponent = Owner.GetComponent<MovementAIComponent>();
    }
}

