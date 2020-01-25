using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleGrabTime : MonoBehaviour
{
    public GameObject wb;
    public GameObject rg;

    public void BottleGrabT()
    {
        //wb.transform.position = new Vector3(-5.12f, 0.9f, 0.21f);
        wb.transform.SetParent(rg.transform);
        wb.transform.localPosition = new Vector3(0.05f, -1.52f, 0.94f);
    }
}
