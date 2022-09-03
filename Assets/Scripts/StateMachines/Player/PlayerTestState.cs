using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) {}

    float timer = 5.0f;
    public override void Enter()
    {
        Debug.Log("Enter");
    }

    public override void Tick(float deltaTime)
    {
        timer -= deltaTime;
        Debug.Log(timer);
        if (timer <= 0)
            stateMachine.SwitchState(new PlayerTestState(stateMachine));
    }

    public override void Exit()
    {
        Debug.Log("Exit");
    }
}
