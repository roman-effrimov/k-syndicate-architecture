using UnityEngine;

namespace CodeBase.Camera
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private float m_RotationAngleX = 45f;
        [SerializeField] private float m_Offset = 15f;
        
        [SerializeField] private Transform m_Target;
        
        void LateUpdate()
        {
            if (m_Target == null)
                return;
            
            var rotation = Quaternion.Euler(m_RotationAngleX, 0, 0);

            transform.rotation = rotation;
            transform.position = rotation * new Vector3(0, 0, -m_Offset) + GetFollowPosition();
        }

        public void SetTarget(Transform target) => m_Target = target;
        
        private Vector3 GetFollowPosition()
        {
            var position = m_Target.position;
            position.y += m_Offset;
            return position;
        }
    }
}