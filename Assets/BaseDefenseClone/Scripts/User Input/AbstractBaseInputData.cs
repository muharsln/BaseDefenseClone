using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.UserInput
{
    public abstract class AbstractBaseInputData : ScriptableObject
    {
        public abstract void ProccessInput(float horizontal, float vertical);
    }
}