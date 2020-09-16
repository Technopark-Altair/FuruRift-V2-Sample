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
        
    }
}
