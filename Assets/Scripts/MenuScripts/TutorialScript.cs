using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject tutorialScreen;
    public GameObject classTypeScreen;

    // Add extra methods for skipping tutorial and going to class builder and moving between tutorial screens

    public void BackToTitle()
    {
        titleScreen.SetActive(true);
        tutorialScreen.SetActive(false);
        classTypeScreen.SetActive(false);
    }

    public void GoToClassBuilder()
    {
        titleScreen.SetActive(false);
        tutorialScreen.SetActive(false);
        classTypeScreen.SetActive(true);
    }
}
