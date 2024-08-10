using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CubeAnimation : MonoBehaviour
{
    [SerializeField] private GameObject cube1;
    [SerializeField] private Rigidbody cube2;
    [SerializeField] private GameObject cube3;

    [SerializeField] private int speed;
    [SerializeField] private float scale;
    
    private PlayableDirector animCube;

    private void Awake()
    {
        animCube = GetComponent<PlayableDirector>();
    }

    /// <summary>
    /// ��������� ������� �������
    /// </summary>
    public void ScaleObject()
    {
        cube1.transform.localScale = new Vector3(1 * scale, 1 * scale, 1 * scale);
    }

    /// <summary>
    /// ���������� ������� ����
    /// </summary>
    public void AddForceObject()
    {
        cube2.AddForce(transform.up * speed);
    }

    /// <summary>
    /// ����������� �������
    /// </summary>
    public void DestroyObject()
    {
        Destroy(cube3);
    }
}
