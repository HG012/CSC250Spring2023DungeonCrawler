using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    public bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        print(MasterData.whereDidIComeFrom);
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        MasterData md = new MasterData();
        this.isMoving = false;

    }

    

    private void OnTriggerExit(Collider other)
    {
       if(other.gameObject.tag.Equals("exit"))
        {
            if (other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
            }

            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
            }

            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
            }



            SceneManager.LoadScene("SampleScene")
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed)
            this.isMoving = true;
        }

      
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed)
            this.isMoving = true;
        }
      
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed)
            this.isMoving = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed)
            this.isMoving = true;
        }
    }
}