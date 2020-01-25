using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGHitDown : MonoBehaviour
{

    public GameObject rg;
    public GameObject mc;

    bool inRbd = false;
    Vector3 rgPos;

    // Start is called before the first frame update
    void Start()
    {
        rgPos = rg.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //rg.transform.SetParent(mc.transform);
            if (!inRbd)
            {
                //rg.transform.SetParent(rtd.transform);
                rg.transform.localPosition = new Vector3(0.74f, 1.47f, 3.57f);
                inRbd = true;
            }
        }
        else if (inRbd)
        {
            this.GetComponent<RGHitDown>().enabled = false;
            //rg.transform.SetParent(null);
            rg.transform.localPosition = rgPos;
            inRbd = false;
        }
    }
}
