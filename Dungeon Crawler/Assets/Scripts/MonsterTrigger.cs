using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterTrigger : MonoBehaviour
{
    public bool enableFights = true;
    public float chanceToGetIntoFight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(this.enableFights && MasterData.canGetIntoFight)
        {
            int chanceToFight = Random.Range(1, 100);

            if (chanceToFight <= this.chanceToGetIntoFight)
            {
                // print("Start a Fight");
                SceneManager.LoadScene("FIGHT SCENE");
                MasterData.canGetIntoFight = false;

                //turn off music
                Destroy(MasterData.musicLooper);
                MasterData.musicLooper = null;
            }
            else
            {
                print("No monsters found");
            }
            print("Entered Monster Trigger!!!!!! - " + chanceToFight);
        }
       
    }
}
