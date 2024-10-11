using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public StateMachine stateMachine { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        stateMachine = new StateMachine();


    }

    protected override void Start()
    {
        base.Start();
        //stateMachine.Initalize();
    }

    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();
    }
}
