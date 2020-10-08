using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float xtime = 10;

    void Update()
    {        
        var xDelta = 2 * Mathf.PI / xtime;
        var xtimePosition = (Time.time % xtime);
        var xposition = Mathf.Cos(xtimePosition * xDelta);
        var xRotation = xposition * 30;

        transform.eulerAngles = new Vector3(xRotation, 0, 0);
    }
}
