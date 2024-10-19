using UnityEngine;

namespace Command.Ex4
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private LayerMask obstacleLayer;
        
        private const float BoardSpacing = 1f;

        public void Move(Vector3 movement)
        {
            transform.position += movement;
        }

        public bool IsValidMove(Vector3 movement)
        {
            return !Physics.Raycast(transform.position, movement, BoardSpacing, obstacleLayer);
        }
    }
}