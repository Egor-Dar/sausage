using GameScene.Inputs.PC;
using UnityEngine;
using AndroidInput = GameScene.Inputs.Android.AndroidInput;

namespace GameScene.Inputs.Factory
{
    public class AndroidFactory: MonoBehaviour, IUIFactory
    {
        [SerializeField] private AndroidInput input;
        public InputBase CreateInput()
        {
            return Instantiate(input);
        }
    }
}