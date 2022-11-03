using BaseDefenseClone.UserInput;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    public class PlayerAnimationController : MonoBehaviour
    {
        private AbstractBaseAnimationState _currentState;

        public PlayerIdleState IdleState = new PlayerIdleState();
        public PlayerRunState RunState = new PlayerRunState();

        private void Start()
        {
            _currentState = IdleState;
            _currentState.Start(this);
        }

        private void Update()
        {
            _currentState.Update(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            _currentState.OnTriggerEnter(other);
        }

        public void ChangeState(AbstractBaseAnimationState state)
        {
            _currentState = state;
            _currentState.Start(this);
        }
    }
}