using Assets.Scripts.Characters;
using Assets.Scripts.Popup;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ASolution : MonoBehaviour
{
    public string Name;
    public GameObject solutionObject;
    public UnityEvent confirmChoice;

    // To get character of the problem.
    public Problem RelevantProblem = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // Entry point of contact for the player. When player has clicked upon button.
    public void OnMouseDown()
    {
        if (HasParentProblem())
        {
            // Perform character specific actions.
            ApplyToProblem(RelevantProblem);

            // Close popup.
            confirmChoice.Invoke();
        }
        else
        {
            Debug.Log("No global problem present yet");
            // Notify all users to apply this solution.

            // Perform action with this solution to all users.
        }
    }

    // Applies effect to
    public void ApplyToProblem(IProblem problem)
    {
        // Get Character relevant to problem

        // Get type of problem information.

        // Solve the problem.
        throw new NotImplementedException();
    }

    public void SolveProblem(GodCharacter character)
    {
        // If in solution. A relation to problem and problem to Character is required.
        // If in problem. Parent relation is required, but not directly from solution to character.

        // Apply the effects of the solution to the character
        // Picks the relevant modifier
        // Adds the solution modifiers
        // Calculate chance
        // If successfull, destroy popup.
        // Apply modifier as new value to persona.
        // Otherwise a negative popup for 2 seconds should show up.
        throw new NotImplementedException();
    }

    public void ConfirmChoice()
    {
        throw new NotImplementedException();
    }

    private bool HasParentProblem()
    {
        return (RelevantProblem != null);
    }


}
