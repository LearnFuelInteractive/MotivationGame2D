using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScreenScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject classTypeScreen;

    void Start()
    {
        
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        classTypeScreen.SetActive(true);
    }
}
