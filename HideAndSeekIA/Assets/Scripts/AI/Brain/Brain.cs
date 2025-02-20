using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    [SerializeField] FSM fsm = null;
    // [SerializeField] State currentState = null;

    void Start()
    {
        Init();

    }

    void Update()
    {
        //Si y il a une FSM , alors on appelle son "Update"
        if(fsm != null)
            fsm.Update();
    }

    void Init()
    {
        fsm = new FSM();



        //Init State//
        MoveToLocationState _movementState = new MoveToLocationState(fsm, gameObject);
        IdleState _idleState = new IdleState(fsm, gameObject);

        //Init State//

        //Add Transition//
        fsm.AddTransition(_movementState , _idleState , () => _movementState.MovementAIComponent.IsAtLocation);
        fsm.AddTransition(_idleState, _movementState , () => 1 < 0);
        // fsm
        //Add Transition//



        fsm.SetNextState(_movementState);
    }
}
