using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    // Contains popup object
    public GameObject popUp;
    public Problem problemAction;

    // Contains problem
    // Contains player

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {  
    }

    public void ShowPopup()
    {
        popUp.SetActive(true);
    }

    public void HidePopup()
    {
        popUp.SetActive(false);
    }

    // Shows message screen with button
    public void OnMouseDown()
    {
        problemAction.ShowProblem();
    }
}
