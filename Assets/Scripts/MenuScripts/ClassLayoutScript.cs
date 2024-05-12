using UnityEngine;

public class ClassLayoutScript : MonoBehaviour
{
    public GameObject classTypeScreen;
    public GameObject layoutScreen;
    public GameObject modifiersScreen;

    public MenuManager menuManager;

    public void SelectNormal()
    {
        Debug.Log("Normal");
        menuManager.classLayout = 1;
    }

    public void SelectGrouped()
    {
        Debug.Log("Grouped");
        menuManager.classLayout = 2;
    }

    public void SelectSpaced()
    {
        Debug.Log("Spaced");
        menuManager.classLayout = 3;
    }

    public void BackToType()
    {
        classTypeScreen.SetActive(true);
        layoutScreen.SetActive(false);
    }

    public void ForwardToModifiers()
    {
        if (menuManager.classLayout != 0)
        {
            layoutScreen.SetActive(false);
            modifiersScreen.SetActive(true);
        }
        // else show error message
    }
}
