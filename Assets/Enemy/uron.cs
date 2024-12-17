using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uron : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) {
        Debug.Log("colisionenter"+ other.gameObject.name);
        
    }
}
