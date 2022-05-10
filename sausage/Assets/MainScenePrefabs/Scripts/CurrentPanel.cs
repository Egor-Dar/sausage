using CorePlugin.Extensions;
using UnityEngine;

namespace MainScenePrefabs.Scripts
{
    public class CurrentPanel
    {
        private CanvasGroup _currentPanel;

        public void SetPanel(CanvasGroup newPanel)
        {
            _currentPanel?.ChangeGroupState(false);
            _currentPanel = newPanel;
            _currentPanel.ChangeGroupState(true);
        }
    }
}