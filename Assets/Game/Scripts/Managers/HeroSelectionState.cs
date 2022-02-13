﻿using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace StateMachine.GameStateMachine
{
    public class HeroSelectionState : SceneLoadState
    {
        public static UnityEvent OnHeroSelectionStarted = new UnityEvent();

        public HeroSelectionState(string sceneName) : base(sceneName){}


        public override void Enter()
        {
            LoadScene();
        }

        protected override void OnSceneLoaded()
        {
            HeroManager.SelectedHeroes.Clear();
            OnHeroSelectionStarted?.Invoke();
        }

        public override void Exit()
        {
            UnloadScene();
        }
    }
}