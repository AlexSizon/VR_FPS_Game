using UnityEngine;

namespace System
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 0.8f;
        [SerializeField] private CharacterController characterController;

        private void Update()
        {
            var t = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            if (t != Vector2.zero)
            {
                characterController.Move(new Vector3(-t.x, characterController.transform.position.y, -t.y) *
                                         (moveSpeed * Time.deltaTime));
            }
        }
    }
}