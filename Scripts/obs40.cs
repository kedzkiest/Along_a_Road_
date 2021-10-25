using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs40 : MonoBehaviour
{
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.1f;

        Vector3 vec;

        vec = gameObject.transform.localScale;

        vec.x = Mathf.Abs(8 * Mathf.Cos(t));

        gameObject.transform.localScale = vec;
    }
}
