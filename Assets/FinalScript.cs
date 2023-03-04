using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            int buildIndex = SceneManager.GetActiveScene().buildIndex;
            if (buildIndex == 1){
                SceneManager.LoadScene(0);
            }
            else{
                SceneManager.LoadScene(1);
            }
        }
    }
}

