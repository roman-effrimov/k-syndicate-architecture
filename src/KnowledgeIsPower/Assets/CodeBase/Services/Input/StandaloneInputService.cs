using UnityEngine;

namespace CodeBase.Services.Input
{
    public class StandaloneInputService : InputService
    {
        public override Vector2 MovementAxis => GetUnityInputAxis();

        public override bool IsAttackButtonUp => UnityEngine.Input.GetButtonUp(FIRE_BUTTON_NAME);
        private static Vector2 GetUnityInputAxis() => new Vector2(UnityEngine.Input.GetAxis(HORIZONTAL_AXIS_NAME), UnityEngine.Input.GetAxis(VERTICAL_AXIS_NAME));
    }
}