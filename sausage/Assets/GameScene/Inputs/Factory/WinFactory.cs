using GameScene.Inputs.PC;
using UnityEngine;

namespace GameScene.Inputs.Factory
{
    public class WinFactory: MonoBehaviour, IUIFactory
    {
        [SerializeField] private PCInput input;
        public InputBase CreateInput()
        {
            return Instantiate(input);
        }
    }
}