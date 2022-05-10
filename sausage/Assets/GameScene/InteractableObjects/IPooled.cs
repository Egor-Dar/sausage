namespace GameScene.InteractableObjects
{
    public interface IPooled
    {
        public void GetObjectOutPool();
        public void ReturnInPool();
    }
}