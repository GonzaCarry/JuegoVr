using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMoveTime : MonoBehaviour
{
    public GameObject bottle;

    public void GrapBottle()
    {
        bottle.transform.position = new Vector3(0.04862309f, -1.524094f, 0.9421391f);
    }
}
