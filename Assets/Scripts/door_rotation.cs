using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_rotation : MonoBehaviour
{
    private Animator anim;
    private AudioSource Entry_door_sound;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Entry_door_sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("opening", true);
        Entry_door_sound.Play();
        Entry_door_sound.PlayDelayed(5f);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("opening", false);
        Entry_door_sound.Play();
        Entry_door_sound.PlayDelayed(5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
