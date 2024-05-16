using UnityEngine;

public class TitleScreenScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject tutorialScreen;

    public void StartGame()
    {
        titleScreen.SetActive(false);
        tutorialScreen.SetActive(true);
    }
}
