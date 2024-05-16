using UnityEngine;
using UnityEngine.SceneManagement;

public class ModifierScript : MonoBehaviour
{
    public GameObject layoutScreen;
    public GameObject modifiersScreen;
    public GameObject summaryScreen;

    public MenuManager menuManager;

    public void BackToLayout()
    {
        layoutScreen.SetActive(true);
        modifiersScreen.SetActive(false);
    }

    public void ForwardToSummary()
    {
        modifiersScreen.SetActive(false);
        summaryScreen.SetActive(true);
    }

    public void AddSelection(string name)
    {
        if (menuManager.modifiers.Count < 3)
            menuManager.modifiers.Add(name);
    }
}
