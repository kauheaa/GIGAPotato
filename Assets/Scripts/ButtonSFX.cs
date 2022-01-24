using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class ButtonSFX : MonoBehaviour
{
    [SerializeField]
    [EventRef]
    public string soundEvent = null;

    
    public void PlaySoundEvent()
    {
        if (soundEvent != null)
        {
            RuntimeManager.PlayOneShot(soundEvent);
        }
    }
    private static ButtonSFX instance;


    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}   


    

