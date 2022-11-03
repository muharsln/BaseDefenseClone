using BaseDefenseClone.UserInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _movementInputData;
        [SerializeField] private Rigidbody _movementRigidbody;

        [SerializeField] private MovementSettings _movementSettings;

        private void FixedUpdate()
        {
            PlayerMove();
        }

        private void PlayerMove()
        {
            _movementRigidbody.velocity = new Vector3(_movementInputData.Horizontal * _movementSettings.MovementSpeed,
                _movementRigidbody.velocity.y,
                _movementInputData.Vertical * _movementSettings.MovementSpeed);

        }
        private void Update()
        {
            if (Input.GetMouseButton(0))
                PlayerDirRotate();
        }

        private void PlayerDirRotate()
        {
            _movementSettings.MovementDirection = Vector3.forward * _movementInputData.Vertical + Vector3.right * _movementInputData.Horizontal;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(_movementSettings.MovementDirection), _movementSettings.RotationSpeed * Time.fixedDeltaTime);
        }
    }
}