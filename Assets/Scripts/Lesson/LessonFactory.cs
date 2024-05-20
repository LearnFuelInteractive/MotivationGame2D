using Assets.Scripts.Other;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class LessonFactory
{

    private LessonComponentFactory _factory = new LessonComponentFactory(); 
    public Lesson CreateTheoryLesson()
    {
        Lesson lesson = new Lesson();
        lesson.name = "Theory";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.8f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.3f);
        modifiers.Add(CompetenceType.CONNECTION, 0.3f);
        lesson.modifiers = modifiers;
        lesson.lessonComponents = _factory.CreateLessonComponentsFromPlayerPrefs();
        return lesson;

    }

    public Lesson CreateCollegeLesson()
    {
        Lesson lesson = new Lesson();
        lesson.name = "College";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.8f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.1f);
        modifiers.Add(CompetenceType.CONNECTION, 0.2f);
        lesson.modifiers = modifiers;
        lesson.lessonComponents = _factory.CreateLessonComponentsFromPlayerPrefs();
        return lesson;

    }

    public Lesson CreatePracticalLesson()
    {
        Lesson lesson = new Lesson();
        lesson.name = "Practical";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 1f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.5f);
        modifiers.Add(CompetenceType.CONNECTION, 0.2f);
        lesson.lessonComponents = _factory.CreateLessonComponentsFromPlayerPrefs();
        lesson.modifiers = modifiers;
        return lesson;

    }

    public Lesson CreateGroupLesson()
    {
        Lesson lesson = new Lesson();
        lesson.name = "Group";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.7f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.3f);
        modifiers.Add(CompetenceType.CONNECTION, 0.9f);
        lesson.lessonComponents = _factory.CreateLessonComponentsFromPlayerPrefs();
        lesson.modifiers = modifiers;
        return lesson;

    }

    public Lesson CreateLessonWithPlayerPrefs()
    {

        string chosenLessonName = PlayerPrefs.GetString("SelectedClassType");
        Debug.Log("CHOSEN LESSON NAME:" + chosenLessonName);
        switch (chosenLessonName)
        {
            case "Theory": return CreateTheoryLesson();
            case "College": return CreateCollegeLesson();
            case "Practical": return CreatePracticalLesson();
            case "Group": return CreateGroupLesson();


        }

        return null;
    }
}
