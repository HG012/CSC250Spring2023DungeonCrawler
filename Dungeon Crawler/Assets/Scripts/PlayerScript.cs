using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed)
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
           MasterData.count++
           SceneManager.LoadScene("DungeonRoom")
           SceneManager.LoadScene;
        }
    }
}
