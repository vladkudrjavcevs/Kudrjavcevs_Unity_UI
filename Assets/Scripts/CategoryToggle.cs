using UnityEngine;
using UnityEngine.UI;

public class CategoryToggle : MonoBehaviour
{
    public Toggle toggle;
    public GameObject targetPanel;

    private void Start()
    {
        if (toggle != null)
        {
            toggle.onValueChanged.AddListener(TogglePanel);
            TogglePanel(toggle.isOn);
        }
    }

    public void TogglePanel(bool isOn)
    {
        Debug.Log("TogglePanel: " + isOn);

        if (targetPanel != null)
        {
            targetPanel.SetActive(isOn);
        }
    }
}