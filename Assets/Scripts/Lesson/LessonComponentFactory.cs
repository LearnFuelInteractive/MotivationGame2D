using Assets.Scripts.Other;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonComponentFactory
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
        return new LessonComponent("Kahoot", 0.8f, 0.1f, 0.4f);

    }
}
