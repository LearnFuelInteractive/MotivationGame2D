using UnityEngine;

public class ClassLayoutScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject classTypeScreen;
    public GameObject layoutScreen;
    public GameObject modifiersScreen;
    private string selectedClassLayoutKey = "SelectedClassLayout";

    public MenuManager menuManager;

    public void SelectNormal()
    {
        Debug.Log("Normal");
        menuManager.normalLayoutSelected = true;
        menuManager.groupedLayoutSelected = false;
        menuManager.spacedLayoutSelected = false;
        menuManager.layoutSelected = true;
        PlayerPrefs.SetString(selectedClassLayoutKey, "NormalClassLayout");
    }

    public void SelectGrouped()
    {
        Debug.Log("Grouped");
        menuManager.normalLayoutSelected = false;
        menuManager.groupedLayoutSelected = true;
        menuManager.spacedLayoutSelected = false;
        menuManager.layoutSelected = true;
        PlayerPrefs.SetString(selectedClassLayoutKey, "GroupClassLayout");
    }

    public void SelectSpaced()
    {
        Debug.Log("Spaced");
        menuManager.normalLayoutSelected = false;
        menuManager.groupedLayoutSelected = false;
        menuManager.spacedLayoutSelected = true;
        menuManager.layoutSelected = true;
    }

    public void BackToType()
    {
        titleScreen.SetActive(true);
        classTypeScreen.SetActive(false);
    }

    public void ForwardToModifiers()
    {
        if (menuManager.layoutSelected)
        {
            titleScreen.SetActive(false);
            classTypeScreen.SetActive(false);
            layoutScreen.SetActive(false);
            modifiersScreen.SetActive(true);
        }
        // else show error message
    }
}
