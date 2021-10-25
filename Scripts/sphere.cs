using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public float amp;
    public float cycle;
    public bool phase;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f;
        if(phase == true){
            this.transform.Translate(0, 0, amp * Mathf.Sin(cycle * t));
        }
        else{
            this.transform.Translate(0, 0, -amp * Mathf.Sin(cycle * t));
        }
        
    }
}
