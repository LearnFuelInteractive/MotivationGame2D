using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModifierScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject classTypeScreen;
    public GameObject layoutScreen;
    public GameObject modifiersScreen;

    public MenuManager menuManager;

    public void BackToLayout()
    {
        titleScreen.SetActive(false);
        classTypeScreen.SetActive(false);
        layoutScreen.SetActive(true);
        modifiersScreen.SetActive(false);
    }

    public void ForwardToSummary()
    {
        titleScreen.SetActive(false);
        classTypeScreen.SetActive(false);
        layoutScreen.SetActive(false);
        modifiersScreen.SetActive(false);
        SceneManager.LoadScene("ClassroomScene");
    }

    public void SelectKahoot()
    {
        menuManager.kahootSelected = true;
    }
}
