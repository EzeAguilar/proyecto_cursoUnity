using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float ForceAdelante;
    public float SideForce;
    private float speed = 35;

    // Start is called before the first frame update
    void Start () {
        

	}


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10 || transform.position.x <=-852.9){
            SceneManager.LoadScene("SampleScene");
        }

        float moveHorizontal = Input.acceleration.x;
        Vector3 movement = new Vector3(0.0f, 0.0f, moveHorizontal);
        transform.position += movement*speed*Time.deltaTime;
        rb.AddForce(new Vector3(-ForceAdelante,0,0)*Time.deltaTime);

        /*
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(new Vector3(0,0,-ForceAdelante)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(new Vector3(0,0,ForceAdelante)*Time.deltaTime);
        }
        */

        
	}

}