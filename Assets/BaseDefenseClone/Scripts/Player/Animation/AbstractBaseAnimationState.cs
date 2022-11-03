using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    public abstract class AbstractBaseAnimationState
    {
        protected Animator animator;

        public virtual void Start(PlayerAnimationController player)
        {
            animator = player.GetComponent<Animator>();
        }

        public abstract void Update(PlayerAnimationController player);

        public abstract void OnTriggerEnter(Collider collision);
    }
}