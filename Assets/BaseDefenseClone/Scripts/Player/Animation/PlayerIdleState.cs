using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    public class PlayerIdleState : AbstractBaseAnimationState
    {
        public override void Update(PlayerAnimationController player)
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.ChangeState(player.RunState);
            }
        }
        public override void OnTriggerEnter(Collider collision)
        {

        }
    }
}