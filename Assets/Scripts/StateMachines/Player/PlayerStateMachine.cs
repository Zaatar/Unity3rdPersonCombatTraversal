using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    private void Start()
    {
        Debug.Log("In Player State Machine");
        SwitchState(new PlayerTestState(this));
    }
}
