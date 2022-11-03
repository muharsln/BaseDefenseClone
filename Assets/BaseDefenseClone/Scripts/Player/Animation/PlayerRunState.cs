using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    public class PlayerRunState : AbstractBaseAnimationState
    {
        public override void Start(PlayerAnimationController player)
        {
            base.Start(player);
            animator.SetBool("Run", true);
        }

        public override void Update(PlayerAnimationController player)
        {
            if (Input.GetMouseButtonUp(0))
            {
                animator.SetBool("Run", false);
                player.ChangeState(player.IdleState);
            }
        }

        public override void OnTriggerEnter(Collider collision)
        {

        }
    }
}