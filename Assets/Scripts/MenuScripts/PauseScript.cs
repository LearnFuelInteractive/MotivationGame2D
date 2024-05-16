using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && pauseScreen.activeSelf)
        {
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.P) && !pauseScreen.activeSelf)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
    }

    public void Pause()
    {
        if (pauseScreen.activeSelf)
        {
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
        }
        else if (!pauseScreen.activeSelf)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
    }
}
