using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ClassTypeScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject classTypeScreen;
    public GameObject layoutScreen;

    public MenuManager menuManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SelectTheory()
    {
        Debug.Log("Theory");
        menuManager.theorySelected = true;
        menuManager.practicalSelected = false;
        menuManager.collegeSelected = false;
        menuManager.groupSelected = false;
        menuManager.typeSelected = true;
    }

    public void SelectPractical()
    {
        Debug.Log("Practical");
        menuManager.theorySelected = false;
        menuManager.practicalSelected = true;
        menuManager.collegeSelected = false;
        menuManager.groupSelected = false;
        menuManager.typeSelected = true;
    }

    public void SelectCollege()
    {
        Debug.Log("College");
        menuManager.theorySelected = false;
        menuManager.practicalSelected = false;
        menuManager.collegeSelected = true;
        menuManager.groupSelected = false;
        menuManager.typeSelected = true;
    }

    public void SelectGroup()
    {
        Debug.Log("Group");
        menuManager.theorySelected = false;
        menuManager.practicalSelected = false;
        menuManager.collegeSelected = false;
        menuManager.groupSelected = true;
        menuManager.typeSelected = true;
    }

    public void BackToTitle()
    {
        titleScreen.SetActive(true);
        classTypeScreen.SetActive(false);
    }

    public void ForwardToLayout()
    {
        if (menuManager.typeSelected)
        {
            titleScreen.SetActive(false);
            classTypeScreen.SetActive(false);
            layoutScreen.SetActive(true);
        }
        // else show error text
    }
}
