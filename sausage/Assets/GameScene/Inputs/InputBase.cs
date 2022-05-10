using System;
using CorePlugin.Core;
using CorePlugin.Cross.Events.Interface;
using CorePlugin.Extensions;
using GameScene.Player.Delegates;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameScene.Inputs
{
    public abstract class InputBase : MonoBehaviour, IEventHandler
    {
        protected float MoveDir;
        private PlayerDelegates.Movement _movement;
        public abstract void Action(InputAction.CallbackContext context);

        private void Update()
        {
            _movement?.Invoke(MoveDir);
            Debug.Log(MoveDir);
        }

        public void InvokeEvents()
        {
        }

        public void Subscribe(params Delegate[] subscribers)
        {
            EventExtensions.Subscribe(ref _movement, subscribers);
        }

        public void Unsubscribe(params Delegate[] unsubscribers)
        {
            EventExtensions.Unsubscribe(ref _movement, unsubscribers);
        }
    }
}