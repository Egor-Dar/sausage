using GameScene.Inputs.Android;
using GameScene.Inputs.PC;

namespace GameScene.Inputs
{
    public interface IUIFactory
    {
        public InputBase CreateInput();
    }
}