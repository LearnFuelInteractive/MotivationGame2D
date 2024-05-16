using Assets.Scripts.Other;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class LessonFactory : ScriptableObject
{

    private LessonComponentFactory _factory = ScriptableObject.CreateInstance<LessonComponentFactory>();
    public Lesson CreateTheoryLesson()
    {
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
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
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
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
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
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
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
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
