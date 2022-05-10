using GameScene.InteractableObjects;
using UnityEngine;
using UnityEngine.Pool;

namespace GameScene.Spawner
{
    public class GroundSpawner : MonoBehaviour
    {
        [SerializeField] private IGrounded prefab1;
        private ObjectPool<IGrounded> _objects;
    }
}