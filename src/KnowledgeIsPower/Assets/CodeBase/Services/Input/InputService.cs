using UnityEngine;

namespace CodeBase.Services.Input
{
    public abstract class InputService : IInputService
    {
        protected const string HORIZONTAL_AXIS_NAME = "Horizontal";
        protected const string VERTICAL_AXIS_NAME = "Vertical";
        protected const string FIRE_BUTTON_NAME = "Fire";
        
        public abstract Vector2 MovementAxis { get; }
        public abstract bool IsAttackButtonUp { get; }
    }
}