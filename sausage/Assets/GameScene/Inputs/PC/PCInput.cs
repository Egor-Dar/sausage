using UnityEngine;
using UnityEngine.InputSystem;

namespace GameScene.Inputs.PC
{
    public class PCInput : InputBase
    {
        public override void Action(InputAction.CallbackContext context)
        {
            MoveDir = context.ReadValue<float>();
        }
    }
}