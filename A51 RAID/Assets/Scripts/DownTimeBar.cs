using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTimeBar : MonoBehaviour
{

    private Transform bar;

    // Start is called before the first frame update
    void Start()
    {
        bar.localScale = new Vector3(3f, 0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
