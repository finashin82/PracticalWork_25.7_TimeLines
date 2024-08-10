using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class FlashFireTourch : MonoBehaviour
{
    [SerializeField] private List<GameObject> tourch = new List<GameObject>();

    [SerializeField] private float timerBetweenFlashes;

    [SerializeField] private AudioSource flashSource;

    private float timerFlash;

    private int lengthArray, i=0;

    private bool isPermissionFlash;

    private void Awake()
    {
        lengthArray = tourch.Count;

        timerFlash = timerBetweenFlashes;
    }

    private void Update()
    {
        if (isPermissionFlash)
        {
            timerFlash -= Time.deltaTime;

            if (timerFlash < 0)
            {
                FlashFireOn();

                flashSource.Play();

                timerFlash = timerBetweenFlashes;
            }
        }

        if (i == lengthArray)
        {
            isPermissionFlash = false;
        }
    }

    /// <summary>
    /// Разрешение на включение огней
    /// </summary>
    public void PermissionFlash()
    {
        isPermissionFlash = true;
    }

    /// <summary>
    /// Зажигаем огни
    /// </summary>
    private void FlashFireOn()
    {
        if (i < lengthArray)
        {
            tourch[i].SetActive(true);
            i++;
        }        
    }   
}