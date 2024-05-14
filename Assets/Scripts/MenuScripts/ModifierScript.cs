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

    public void SelectKahoot()
    {
        if (!menuManager.modifiers.Contains(1))
            menuManager.modifiers.Add(1);
        // else show error message
    }
}
