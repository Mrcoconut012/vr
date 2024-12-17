using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class NewEnemyAnim : MonoBehaviour
{
    private Animator anim;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T) == true){
            GetComponent<Animator>().Play("New_State");
        }
        
        
        
    }

    
}
