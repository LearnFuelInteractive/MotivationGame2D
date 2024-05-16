using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SummaryScript : MonoBehaviour
{
    public MenuManager menuManager;

    public TextMeshProUGUI classTypeText;
    public GameObject classLayout;
    public Sprite normalLayout;
    public Sprite groupedLayout;
    public Sprite spacedLayout;
    public TextMeshProUGUI classModifiersText;

    private readonly string selectedClassTypeKey = "SelectedClassType";
    private readonly string selectedClassLayoutKey = "SelectedClassLayout";
    private readonly string selectedModifiersKey = "SelectedModifiers";
    private string modifierText = "";

    public GameObject modifiersScreen;
    public GameObject summaryScreen;

    private void OnEnable()
    {
        Debug.Log("Summary Enabled");
        ClassTypeCheck();
        ClassLayoutCheck();
        ModifiersCheck();
    }

    public void BackToModifiers()
    {
        summaryScreen.SetActive(false);
        modifiersScreen.SetActive(true);
    }

    public void Finish()
    {
        // Move to game scene
        PlayerPrefs.SetString(selectedModifiersKey, modifierText);
        SceneManager.LoadScene("ClassroomScene");
    }

    private void ClassTypeCheck()
    {

        switch (menuManager.classType)
        {
            case 1:
                {
                    classTypeText.text = "-Theorie";
                    break;
                }
            case 2:
                {
                    classTypeText.text = "-Practicum";
                    break;
                }
            case 3:
                {
                    classTypeText.text = "-Hoorcollege";
                    break;
                }
            case 4:
                {
                    classTypeText.text = "-Groepsopdracht";
                    break;
                }
            default:
                {
                    classTypeText.text = "-Theorie";
                    break;
                }
        }
    }

    private void ClassLayoutCheck()
    {

        switch (menuManager.classLayout)
        {
            case 1:
                {
                    classLayout.GetComponent<Image>().sprite = normalLayout;
                    PlayerPrefs.SetString(selectedClassLayoutKey, "NormalClassLayout");
                    break;
                }
            case 2:
                {
                    classLayout.GetComponent<Image>().sprite = groupedLayout;
                    PlayerPrefs.SetString(selectedClassLayoutKey, "GroupClassLayout");
                    break;
                }
            case 3:
                {
                    classLayout.GetComponent<Image>().sprite = spacedLayout;
                    PlayerPrefs.SetString(selectedClassLayoutKey, "SpacedClassLayout");
                    break;
                }
            default:
                {
                    classLayout.GetComponent<Image>().sprite = normalLayout;
                    PlayerPrefs.SetString(selectedClassLayoutKey, "NormalClassLayout");
                    break;
                }
        }
    }

    private void ModifiersCheck()
    {

        string modifyText = "";
        //for(int i = 0; i < menuManager.modifiers.Count; i++)
        //{
        //    modifierText += menuManager.modifiers[i] + ",";
        //}

        foreach(string modifier in menuManager.modifiers)
        {
            Debug.Log(modifier);
            modifyText += modifier + ",";
            modifierText += modifier + "-";
        }
        classModifiersText.text = modifyText;
        PlayerPrefs.SetString("SelectedLessonComponents", modifyText);
    }
}
