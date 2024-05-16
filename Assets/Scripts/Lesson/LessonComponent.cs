using Assets.Scripts.Other;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonComponent
{
    public string Name;
    public Dictionary<CompetenceType, float> modifiers;
    
    public LessonComponent(string name, float competenceModifier, float autonomyModifier, float connectionModifier) {
    
        Name = name;
        modifiers = new Dictionary<CompetenceType, float>();
        modifiers.Add(CompetenceType.COMPETENCE, competenceModifier);
        modifiers.Add(CompetenceType.AUTONOMY, autonomyModifier);
        modifiers.Add(CompetenceType.CONNECTION, connectionModifier);

    }
}
