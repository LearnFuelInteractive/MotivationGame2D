using Assets.Scripts.Other;
using Assets.Scripts.ProblemClass;
using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class LessonFactory : ScriptableObject
{
    public Lesson createTheoryLesson()
    {
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
        lesson.name = "Theory";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.8f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.3f);
        modifiers.Add(CompetenceType.CONNECTION, 0.3f);
        lesson.modifiers = modifiers;
        return lesson;

    }

    public Lesson createCollegeLesson()
    {
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
        lesson.name = "College";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.8f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.1f);
        modifiers.Add(CompetenceType.CONNECTION, 0.2f);
        lesson.modifiers = modifiers;
        return lesson;

    }

    public Lesson createPracticalLesson()
    {
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
        lesson.name = "Practical";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 1f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.5f);
        modifiers.Add(CompetenceType.CONNECTION, 0.2f);
        lesson.modifiers = modifiers;
        return lesson;

    }

    public Lesson createGroupLesson()
    {
        Lesson lesson = ScriptableObject.CreateInstance<Lesson>();
        lesson.name = "Practical";
        var modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, 0.7f);
        modifiers.Add(CompetenceType.AUTONOMY, 0.3f);
        modifiers.Add(CompetenceType.CONNECTION, 0.9f);
        lesson.modifiers = modifiers;
        return lesson;

    }
}
