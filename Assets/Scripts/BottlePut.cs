using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottlePut : MonoBehaviour
{
    public GameObject wb;
    public GameObject table;

    public void BottlePutOn()
    {
        //BW.transform.position = new Vector3(-5.12f, 0.9f, 0.21f);
        wb.transform.SetParent(table.transform);
        wb.transform.localPosition = new Vector3(-0.87f, 0.36f, 0.57f);
    }
}
