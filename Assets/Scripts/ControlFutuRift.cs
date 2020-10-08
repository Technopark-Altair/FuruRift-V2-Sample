using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ChairControl.ChairWork;
using ChairControl.ChairWork.Options;

public class ControlFutuRift : MonoBehaviour
{
    public UdpOptions udpOptions;

    private FutuRiftController futuRiftController;
    void OnEnable()
    {
        futuRiftController = new FutuRiftController(udpOptions);
        futuRiftController.Start();
    }

    void OnDisable()
    {
        futuRiftController.Stop();
    }

    void Update()
    {
        var euler = transform.eulerAngles;
        futuRiftController.Pitch = euler.x > 180 ? euler.x - 360 : euler.x;
        futuRiftController.Roll = euler.z > 180 ? euler.z - 360 : euler.z;
    }
}
