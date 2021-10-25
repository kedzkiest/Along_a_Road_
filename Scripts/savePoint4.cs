using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savePoint4 : MonoBehaviour
{
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Player_Controller.where_to_respawn = 4;
        sound.PlayOneShot(sound.clip);
    }
}