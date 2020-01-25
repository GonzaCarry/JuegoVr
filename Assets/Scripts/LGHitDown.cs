using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LGHitDown : MonoBehaviour
{
    public GameObject mc;
    public GameObject lg;

    bool inlbd = false;
    Vector3 rlPos;

    // Start is called before the first frame update
    void Start()
    {
        rlPos = lg.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //rg.transform.SetParent(mc.transform);
            if (!inlbd)
            {
                //rg.transform.SetParent(rtd.transform);
                lg.transform.localPosition = new Vector3(0.4f, 1.79f, 2.91f);
                inlbd = true;
            }
        }
        else if (inlbd)
        {
            this.GetComponent<LGHitDown>().enabled = false;
            //rg.transform.SetParent(null);
            lg.transform.localPosition = rlPos;
            inlbd = false;
        }
    }
}
