using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public AudioSource filesDialogue;
    public AudioSource introAudio;

    public void CardInserted()
    {
        Debug.Log("itworks");
        introAudio.Stop();
        filesDialogue.Play();
    }

    public void CardRemoved()
    {
        filesDialogue.Pause();
    }
}