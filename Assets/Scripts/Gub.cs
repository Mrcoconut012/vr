using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Gub : MonoBehaviour
{
    private Interactable interactable;
    public SteamVR_Action_Boolean fireAction;
    public Transform barel;
    public ParticleSystem ps;
    
    public AudioClip ac;
    private void Start()
    {
        interactable = GetComponent<Interactable>();
    }
    private void Update() {
        if( interactable.attachedToHand != null){
            SteamVR_Input_Sources hand = interactable.attachedToHand.handType;
            if(/*fireAction[hand].stateDown*/ Input.GetKeyDown(KeyCode.Space)){
                Fire();
                Debug.Log(Health_Enemy.hp);
            }
        }
    }
    private void Fire(){
        ps.Play();
        RaycastHit hit;
        if(Physics.Raycast(barel.position, barel.forward,out hit, 300 )){
            Debug.Log(hit.transform.name);
            GetComponent<AudioSource>().PlayOneShot(ac);
            Health_Enemy.hp--;
        }
    }
}
