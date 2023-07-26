using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BOOM
{
    public class MainMenuState : MonoBehaviour
    {
        StateManager _stateManager;
        public void Begin(StateManager stateManager)
        {
            _stateManager = stateManager;
            gameObject.SetActive(true);
        }

        public void Exit()
        {
            gameObject.SetActive(false);
        }
        public void OnBackButtonClicked()
        {
            _stateManager.ChangeState(UIState.GAME);
        }
    }
}
