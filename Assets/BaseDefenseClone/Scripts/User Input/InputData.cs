using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.UserInput
{
    [CreateAssetMenu(menuName = "BaseDefenseClone/Input/Input Data")]
    public class InputData : AbstractBaseInputData
    {
        [SerializeField] private float _horizontal;
        public float Horizontal { get { return _horizontal; } }

        [SerializeField] private float _vertical;
        public float Vertical { get { return _vertical; } }

        public override void ProccessInput(float horizontal, float vertical)
        {
            _horizontal = horizontal;
            _vertical = vertical;
        }
    }
}