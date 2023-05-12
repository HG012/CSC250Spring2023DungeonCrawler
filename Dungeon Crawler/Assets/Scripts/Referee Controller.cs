using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefereeController : MonoBehaviour
{
    public GameObject monsterGo;
    public GameObject playerGo;
    public TextMeshPro monsterSB;
    public TextMeshPro playerSB;
    private Monster theMonster;

    // Start is called before the first frame update
    void Start()
    {
        this.theMonster = new Monster("goblin");
        monsterSB.text = (this.theMonster.getData());
        this.playerSB.text = (MasterData.p.getData());
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
