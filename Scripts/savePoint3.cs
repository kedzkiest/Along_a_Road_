using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savePoint3 : MonoBehaviour
{
    private AudioSource sound;
    public GameObject sphere1, sphere2, sphere3;

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
        Player_Controller.where_to_respawn = 3;
        sound.PlayOneShot(sound.clip);
        Destroy(sphere1);
        Destroy(sphere2);
        Destroy(sphere3);
    }
}