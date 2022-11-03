using BaseDefenseClone.UserInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private AbstractBaseInputData[] _baseInputs;

    [SerializeField] private FloatingJoystick _joystick;

    private void Update()
    {
        for (int i = 0; i < _baseInputs.Length; i++)
        {
            _baseInputs[i].ProccessInput(_joystick.Horizontal, _joystick.Vertical);
        }
    }
}
