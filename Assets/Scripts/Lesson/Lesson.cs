using Assets.Scripts.Other;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson : ScriptableObject
{
    public string name;
    public Dictionary<CompetenceType, float> modifiers;

    public Lesson(string name, float competenceModifier, float autonomyModifier, float connectionModifier)
    {
        this.name = name;
        modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, competenceModifier);
        modifiers.Add(CompetenceType.AUTONOMY, autonomyModifier);
        modifiers.Add(CompetenceType.CONNECTION, connectionModifier);
    }
    
}
