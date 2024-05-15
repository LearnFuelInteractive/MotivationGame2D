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
        WalkingSound.enabled = true;
    }

    public void DisableWalkingSound()
    {
        WalkingSound.enabled = false;
    }
}
