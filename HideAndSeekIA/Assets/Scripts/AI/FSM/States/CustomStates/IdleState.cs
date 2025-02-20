
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    float timerToWait = 3;
    float timer = 0;
    public float TimerToWait => timerToWait;

    public bool TimerStarted {  get; private set; }

    public IdleState(FSM _fsm, GameObject _owner) : base(_fsm, _owner)
    {

    }


    public override void Enter()
    {
        base.Enter();
        Init();

        Debug.Log("Enter in Idle State");
    }


    public override void Update()
    {

    }

    public override void Exit()
    {
        base.Exit();
    }


    void Init()
    {
        timerToWait = Random.Range(0, 7);


    }

    void StartTimer()
    {
        timer += Time.deltaTime;

    }

    void ResetTimer()
    {
        TimerStarted = false;
        timer = 0;
    }
}
