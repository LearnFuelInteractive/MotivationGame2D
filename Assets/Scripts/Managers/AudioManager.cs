using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource SolvedProblemAudio;
    public AudioSource FailedToSolveProblemAudio;
    public AudioSource WalkingSound;


    public void PlaySolvedProblem()
    {
        SolvedProblemAudio.Play();
    }

    public void PlayFailedToSolveProblem()
    {
        FailedToSolveProblemAudio.Play();
    }

    public void EnableWalkingSound()
    {
        Debug.Log("Walking");
        WalkingSound.enabled = true;
    }

    public void DisableWalkingSound()
    {
        Debug.Log("Stoped Walking");
        WalkingSound.enabled = false;
    }
}
