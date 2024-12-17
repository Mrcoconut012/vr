using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Threading;
public class Button : MonoBehaviour
{
    public void loadscene (){
        if (Input.GetKey (KeyCode.Space)) {
            SceneManager.LoadScene("Game");
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.GetComponent<LeftHand>() ||
        collision.gameObject.GetComponent<RightHand>())
        {
            gameObject.GetComponent<Animator>().SetTrigger("ButtonAnim");
            Thread.Sleep(50);
            SceneManager.LoadScene("Game");
        }
    }
    private void Update() {
        if ( Input.GetKeyDown(KeyCode.Space) == true){
            gameObject.GetComponent<Animator>().SetTrigger("ButtonAnim");
            loadscene();
            
            
        }
        
    }
}
