using UnityEngine;

public class TitleScreenScript : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject tutorialScreen;
    public GameObject creditScreen;

    public void StartGame()
    {
        titleScreen.SetActive(false);
        tutorialScreen.SetActive(true);
    }

    public void GoToCreditScreen()
    {
        creditScreen.SetActive(true);
        titleScreen.SetActive(false);
    }

    public void GoToTitleScreen()
    {
        creditScreen.SetActive(false);
        titleScreen.SetActive(true);
    }
}
