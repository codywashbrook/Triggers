using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject targetObject;
    public AudioSource soundToPlay;
    public GameObject byeObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
        soundToPlay.Play();
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
        byeObject.SetActive(false);
    }
}
