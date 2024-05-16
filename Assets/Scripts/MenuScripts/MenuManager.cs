using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Class type
    public int classType = 0;

    // Class layout
    public int classLayout = 0;

    // Class modifiers
    public HashSet<string> modifiers;

    // Start is called before the first frame update
    void Start()
    {
        this.modifiers = new HashSet<string>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
