using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPersonaGenerator : ScriptableObject
{
    public static Persona GenerateRandomPersona()
    {
        var persona = ScriptableObject.CreateInstance<Persona>();
        persona.Competence = Random.Range(0f, 1f);
        persona.Autonomy = Random.Range(0f, 1f);
        persona.Connection = Random.Range(0f, 1f);
        return persona; 
    }
}
