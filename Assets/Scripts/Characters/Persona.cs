using Assets.Scripts.Other;
using System.Collections.Generic;
using UnityEngine;

public class Persona : ScriptableObject
{

    public float Competence;
    public float Autonomy;
    public float Connection;

    public Persona(float competence, float autonomy, float connection)
    {
        this.Competence = competence;
        this.Autonomy = autonomy;
        this.Connection = connection;
    }


    public void ApplyConfidenceModifier(float currentPercentage)
    {
        currentPercentage *= (1 - Competence);
    }

    public void ApplyAutonomyModifier(float currentPercentage)
    {
        currentPercentage *= (1 - Autonomy);
    }

    public void ApplyConnectionModifier(float currentPercentage)
    {
        currentPercentage += (1 - Connection);
    }

    public float GetCompetence(CompetenceType competenceType)
    {
        var values = new Dictionary<CompetenceType, float>
        {
            { CompetenceType.COMPETENCE, Competence },
            { CompetenceType.AUTONOMY, Autonomy },
            { CompetenceType.CONNECTION, Connection }
        };
        return values.GetValueOrDefault(competenceType, 0.0f);
    }
}
