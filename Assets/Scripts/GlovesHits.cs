using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlovesHits : MonoBehaviour
{
    public GameObject rg;

    public void RHitUp()
    {
        //rg.transform.SetParent(rtd.transform);
        rg.transform.localPosition = new Vector3(0.74f, 1.47f, 3.57f);


        //rg.transform.SetParent(mc.transform);
        //yield return new WaitForSeconds(3);
        //System.Threading.Thread.Sleep(1000);
        //rg.transform.localPosition = new Vector3(1.86f, 0.46f, 1.64f);
        //rg.transform.localPosition = rgPos;
    }
}
