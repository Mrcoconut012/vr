using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tests : MonoBehaviour
{
    public GameObject abc;
    public GameObject abc1;
    void Update()
    {
        abc.transform.position = abc1.transform.position;
    }
}
