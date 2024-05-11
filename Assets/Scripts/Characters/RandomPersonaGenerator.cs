using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPersonaGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public static Persona GenerateRandomPersona()
    {
        return new Persona(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
