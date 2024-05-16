using Assets.Scripts.Other;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonComponentFactory : ScriptableObject
{

    //TODO: Keep expanding this as more lesson components are made.
    public List<LessonComponent> CreateLessonComponentsFromPlayerPrefs()
    {
        string[] selectedLessonComponentStrings = PlayerPrefs.GetString("SelectedLessonComponents").Split(',');
        List<LessonComponent> components = new List<LessonComponent>();  
        foreach (string str in selectedLessonComponentStrings)
        {
            switch (str)
            {
                case "Kahoot": components.Add(CreateKahootComponent());
                    break;
            }
        }
        return components;
    }

    private LessonComponent CreateKahootComponent()
    {
        var component = ScriptableObject.CreateInstance<LessonComponent>();
        component.name = "Kahoot";
        component.modifiers.Add(CompetenceType.CONNECTION, 0.4f);
        component.modifiers.Add(CompetenceType.COMPETENCE, 0.8f);
        component.modifiers.Add(CompetenceType.AUTONOMY, 0.1f);
        return component;

    }
}
