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
        for (var i = 0; i < choicesList.Length - 1; i++)
        {
            choicesText.text += $"{i + 1}. " + choicesList[i] + "\n";
        }
        //foreach (var choice in choicesList) 
        //{
        //    choicesText.text += $"{count}. " + choice + "\n";
        //    count++;
        //}
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
