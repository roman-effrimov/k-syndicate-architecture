using UnityEngine;

namespace CodeBase.Services.Input
{
    public class MobileInputService : InputService
    {
        public override Vector2 MovementAxis => GetSimpleInputAxis();

        public override bool IsAttackButtonUp => SimpleInput.GetButtonUp(FIRE_BUTTON_NAME);
        private Vector2 GetSimpleInputAxis() => new Vector2(SimpleInput.GetAxis(HORIZONTAL_AXIS_NAME), SimpleInput.GetAxis(VERTICAL_AXIS_NAME));
    }
}