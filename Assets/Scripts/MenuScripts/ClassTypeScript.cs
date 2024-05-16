using Assets.Scripts.Other;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ClassTypeScript : MonoBehaviour
{
    public GameObject tutorialScreen;
    public GameObject classTypeScreen;
    public GameObject layoutScreen;

    public MenuManager menuManager;

    public void Selected(string lessonNameAndNumberCSV)
    {
        Debug.Log("CHOSEN LESSON TYPE IN MENU: " + lessonNameAndNumberCSV.Split(',')[0]);
        PlayerPrefs.SetString("SelectedClassType", lessonNameAndNumberCSV.Split(',')[0]);  
        menuManager.classType = int.Parse(lessonNameAndNumberCSV.Split(',')[1]);
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
