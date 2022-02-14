﻿namespace StateMachine.EnemyStateMachine
{
    public abstract class EnemyState : IState
    {
        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}
    }
}