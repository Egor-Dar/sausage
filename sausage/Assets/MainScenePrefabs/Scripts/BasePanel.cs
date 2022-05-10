using UnityEngine;

namespace MainScenePrefabs.Scripts
{
    public class BasePanel : MonoBehaviour
    {
        [SerializeField] private CanvasGroup downPanelPrefab;
        private CanvasGroup _downPanel;
        private CurrentPanel _panelState = new CurrentPanel();

        private void Start()
        {
          _downPanel =  Instantiate(downPanelPrefab, transform);
          _panelState.SetPanel(_downPanel);
        }
    }
}
