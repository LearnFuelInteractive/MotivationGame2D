using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ClassTypeScript : MonoBehaviour
{
    public GameObject tutorialScreen;
    public GameObject classTypeScreen;
    public GameObject layoutScreen;

    public MenuManager menuManager;

    public void SelectTheory()
    {
        Debug.Log("Theory");
        menuManager.classType = 1;
    }

    public void SelectPractical()
    {
        Debug.Log("Practical");
        menuManager.classType = 2;
    }

    public void SelectCollege()
    {
        Debug.Log("College");
        menuManager.classType = 3;
    }

    public void SelectGroup()
    {
        Debug.Log("Group");
        menuManager.classType = 4;
    }

    public void BackToTutorial()
    {
        tutorialScreen.SetActive(true);
        classTypeScreen.SetActive(false);
    }

    public void ForwardToLayout()
    {
        if (menuManager.classType != 0)
        {
            classTypeScreen.SetActive(false);
            layoutScreen.SetActive(true);
        }
        // else show error text
    }
}
