using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleGrab : MonoBehaviour
{
    public GameObject wb;
    public GameObject rg;

    bool inRg = false;
    Vector3 wbPos;

    // Start is called before the first frame update
    void Start()
    {
        wbPos = wb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inRg)
            {
                wb.transform.SetParent(rg.transform);
                wb.transform.localPosition = new Vector3(0.05f, -1.52f, 0.94f);
                inRg = true;
            }
        }
        else if (inRg)
        {
            this.GetComponent<BottleGrab>().enabled = false;
            wb.transform.SetParent(null);
            wb.transform.localPosition = wbPos;
            inRg = false;
        }
    }
}
