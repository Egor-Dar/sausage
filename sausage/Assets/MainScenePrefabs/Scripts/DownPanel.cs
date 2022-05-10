using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MainScenePrefabs.Scripts
{
    public class DownPanel : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        private const string GameScene = "Game";

        private void Start()
        {
            playButton.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene(GameScene);
        }
    }
}