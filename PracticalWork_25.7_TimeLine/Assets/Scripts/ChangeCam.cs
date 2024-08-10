using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    [SerializeField] private GameObject virtCam;

    public void OffVirtCam()
    {
        virtCam.SetActive(false);
    }
}
