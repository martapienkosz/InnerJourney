using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource filesDialogue;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("XRRig"))
        {
            Debug.Log("Coroutine");
            filesDialogue.Play();
            //StartCoroutine(PlayDialogue());
        }
    }

    //IEnumerator PlayDialogue()
    //{
    //    while (!filesDialogue.isPlaying)
    //    {
    //        filesDialogue.Play();
    //        yield return null;

    //    }
    //}
}