using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseDefenseClone.Player
{
    [CreateAssetMenu(menuName = "BaseDefenseClone/Player/Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        [SerializeField] private float _movementSpeed;
        public float MovementSpeed { get { return _movementSpeed; } set { _movementSpeed = value; } }

        [SerializeField] private Vector3 _movementDirection;
        public Vector3 MovementDirection { get { return _movementDirection; } set { _movementDirection = value; } }

        [SerializeField] private float _rotateSpeed;
        public float RotationSpeed { get { return _rotateSpeed; } set { _rotateSpeed = value; } }
    }
}