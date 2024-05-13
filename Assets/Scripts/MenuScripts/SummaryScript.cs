using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class SummaryScript : MonoBehaviour
{
    public MenuManager menuManager;

    public TextMeshProUGUI classTypeText;
    public GameObject classLayout;
    public Sprite normalLayout;
    public Sprite groupedLayout;
    public Sprite spacedLayout;
    public TextMeshProUGUI classModifiersText;

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
    }

    private void ClassTypeCheck()
    {
        classTypeText.text = menuManager.classType switch
        {
            1 => "- Theorie",
            2 => "- Practicum",
            3 => "- Hoorcollege",
            4 => "- Groepsopdracht",
            _ => "- Theorie",
        };
    }

    private void ClassLayoutCheck()
    {
        classLayout.GetComponent<Image>().sprite = menuManager.classLayout switch
        {
            1 => normalLayout,
            2 => groupedLayout,
            3 => spacedLayout,
            _ => normalLayout,
        };
    }

    private void ModifiersCheck()
    {
        foreach (var modifier in menuManager.modifiers)
        {
            classModifiersText.text = modifier switch
            {
                1 => "- Kahoot\n",
                2 => "- 2nd Modifier\n",
                3 => "- 3rd Modifier\n",
                4 => "- 4th Modifier\n",
                _ => "- Kahoot\n",
            };
        }
    }
}
