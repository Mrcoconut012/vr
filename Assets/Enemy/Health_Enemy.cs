using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;


public class Health_Enemy : MonoBehaviour
{
    public GameObject enemy;
    public static float hp = 3;
    private GameObject Obj;
    public static int score;
    private GameObject obj;
    
    private Vector3 a;
    private int b;
    
    
    
    private int Rand(){
        
        return Random.Range(0,3);
    }
    public void copyObject(){
        b = Rand();
        if ( b == 0){
            a = new Vector3(-7,1,-5);

        }
        if ( b == 1){
            a = new Vector3(28,1,30);
        }
        if ( b == 2){
            a = new Vector3(-7,1,63);
        }
        if ( b == 3){
            a = new Vector3(-40,1,28);  
        }
        Instantiate(obj, a, Quaternion.Euler(0,0,0)).SetActive(true);
    }
    private void OnDestroy() {
        hp = 3;
    }
    
    private void Update() {
        obj = this.GameObject();
        if (hp == 0){
            
            
        
            copyObject();
            
            Destroy(this.gameObject);
            
            hp = 3;
            score++;
        }
        
    }
}




