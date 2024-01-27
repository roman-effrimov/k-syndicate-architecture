using CodeBase.Infrastructure;
using CodeBase.Services.Input;
using UnityEngine;

namespace CodeBase.Hero
{
    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private CharacterController m_CharacterController;
        [SerializeField] private float m_MovementSpeed = 8f;

        private IInputService m_InputService;
        private Camera m_Camera;
        
        private void Awake()
        {
            m_InputService = Game.InputService;
        }

        private void Start()
        {
            m_Camera = Camera.main;
        }

        private void Update()
        {
            Vector3 movementVector = m_InputService.MovementAxis;
            if (movementVector.sqrMagnitude > Constants.Math.Epsilon)
            {
                movementVector = m_Camera.transform.TransformDirection(movementVector);
                movementVector.y = 0f;
                movementVector.Normalize();
                
                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;
            m_CharacterController.Move(movementVector * m_MovementSpeed * Time.deltaTime);
        }
    }
}