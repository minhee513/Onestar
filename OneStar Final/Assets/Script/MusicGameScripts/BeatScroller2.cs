using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller2 : MonoBehaviour
{

    public float beatTempo;

    public bool hasStsrted;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStsrted)
        {
            if (Input.anyKeyDown)
            {
                hasStsrted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
