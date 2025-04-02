using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private AudioSource _audiosource;
    public AudioClip _audioclip;
    private SoundManager _soundmanager;
    private BoxCollider2D _boxcollider;
    
      
    
    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
        _soundmanager = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
        _boxcollider = GetComponent<BoxCollider2D>();
    }

    void  OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            _soundmanager.IsFinished = true;
            _soundmanager.PauseBGM();

            _audiosource.PlayOneShot(_audioclip);
        }
    }
}
