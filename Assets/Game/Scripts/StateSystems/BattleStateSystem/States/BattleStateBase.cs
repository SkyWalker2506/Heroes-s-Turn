﻿namespace StateMachine.BattleStateMachine
{
    public abstract class BattleStateBase : IState
    {
        public BattleManager BattleManager;


        public virtual void Enter(){}

        public virtual void Exit(){}

        public virtual void Update(){}
    }
}