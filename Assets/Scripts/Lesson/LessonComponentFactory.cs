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
        List<LessonComponent> lessonComponentss = new List<LessonComponent>();  
        foreach(string str in selectedLessonComponentStrings)
        {
            lessonComponentss.Add(new LessonComponent(str));
        }
        return lessonComponentss;
    }
}
