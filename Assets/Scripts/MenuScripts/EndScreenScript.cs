using TMPro;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    private string choicesKey = "SelectedSolutionsList";
    public TextMeshProUGUI choicesText;
    // Start is called before the first frame update
    void Start()
    {
        var choices = PlayerPrefs.GetString(choicesKey);
        var choicesList = choices.Split(',');
        foreach (var choice in choicesList) 
        {
            choicesText.text += choice + "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Replay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
