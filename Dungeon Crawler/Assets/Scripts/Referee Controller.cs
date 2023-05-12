using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefereeController : MonoBehaviour
{
    public GameObject monsterGo; //game object
    public GameObject playerGo; //game object
    public TextMeshPro monsterSB;
    public TextMeshPro playerSB; 
    private Monster theMonster;
    private DeathMatch theMatch;
    private Rigidbody currRigidBodyOfAttacker;
    private float attackMoveDistance = 2.5f;
    private Vector3 attackerOriginalPosition;

    // Start is called before the first frame update
    void Start()
    {
        this.theMonster = new Monster("goblin");
        monsterSB.text = (this.theMonster.getData());
        this.playerSB.text = (MasterData.p.getData());
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.playerGo, this.monsterGo, this); 
        MasterData.playerShouldAttack = true;
        StartCoroutine(DelayBeforeFight);
        
    }

    IEnumerator DelayBeforeFight()
    {
        yield return new WaitForSeconds(0.5f);
        this.theMatch.fight();

    }
        //thread that acts like workerbee below!!!
        //IEnumerator works like the run method in java

   

    }

  
}
//start coroutine by giving it name of ienumerator