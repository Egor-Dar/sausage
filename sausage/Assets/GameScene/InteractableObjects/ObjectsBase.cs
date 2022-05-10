using System;
using UnityEngine;

namespace GameScene.InteractableObjects
{
    public abstract class ObjectsBase : MonoBehaviour
    {
        protected abstract void OnTriggerEnter(Collider other);
        
    }
}