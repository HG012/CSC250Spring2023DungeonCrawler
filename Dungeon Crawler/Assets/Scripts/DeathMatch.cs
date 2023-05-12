using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMatch :
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;
    private Rigidbody currRigidBodyOfAttacker;
    private float attackMoveDistance = 2.5f;
    private Vector3 attackerOriginalPosition;
    private Inhabitant currentAttacker; // instance of inhabitant that is the current attacker.  Thus we can ask how much damage it can do and how much it can take and visually attack
    private Inhabitant currentTarget;
    private GameObject currentTargetGO;
    private GameObject currentAttackerGO; //game object that represents the dude
    private MonoBehaviour refereeInstance;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO, MonoBehaviour refereeInstance)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
        this.currentAttacker = this.dude1;
        this.currentAttackerGO = this.dude1GO;
        this.currentTarget = this.dude2;
        this.currentTargetGO = this.dude2GO;
        this.refereeInstance = refereeInstance;
        
}

    private IEnumerator JumpCoroutine()
    {
        float duration = 60f;
        float speed = 5f;
        float startTime = Time.time;
        Vector3 startPosition = this.currentAttackerGO.transform.position;

        while(Time.time - startTime < duration)
        {
            float newY = startPosition.y + Mathf.Sin((Time.time - startTime) * speed) * 0.5f;
            this.currentAttackerGO.transform.position = new Vector3(this.currentAttackerGO.transform.position.x, newY, this.currentAttcakerGO;

            
        }
        yield return null;
    }




    //thread that works like workerbee
    IEnumerator MoveObjectRoutine()
    { 

        yield return new WaitForSeconds(0.5f);
        Vector3 originalPosition = this.attackerOriginalPosition;
        Vector3 targetPosition = originalPosition + this.currentAttacker.transform.right * attackMoveDistance;

        this.currRigidBodyOfAttacker.MovePosition(targetPosition);

        yield return new WaitForSeconds(0.5f);

        this.currRigidBodyOfAttacker.MovePosition(originalPosition);

        //try to hit target here

        if(Dice.roll(20) >= this.currentTarget.getAC())
        {
            this.currentTarget.takeDamage(this.currentAttacker.getDamage());
        }

        yield return new WaitForSeconds(0.5f);

        // this.refereeInstance.BroadcastMessage("updateScore");
        ((RefereeController)this.refereeInstance).updateScore();



        if(this.currentTarget.isDead())
        {
            this.currentTargetGO.transform.Rotate(new Vector3(180, 0, 0));

            this.refereeInstance.StartCoroutine(JumpCoroutine());

            ((RefereeController)this.refereeInstance).playWinnerMusic();

            if(this.currentAttackerGO == this.dude1GO)
            {
                ((RefereeController)this.refereeInstance).playWinnerMusic;
            }
        }


        else
        {
           
            this.fight();
        }


        //call the fight method again after the attacker stops moving.
        this.fight();
    }



    public void fight()
    {

   // while (true)
    {

            this.attackerOriginalPosition = this.currentAttackerGO.transform.position; //need "transform.position" because it is a vector 3.
            this.currRigidBodyOfAttacker = this.currentAttackerGO.GetComponent<Rigidbody>(); //rigidbody associated with whoever is currently attacking
            this.attackMoveDistance *= -1;

            if(this.currentAttackerGO == this.dude1GO)
            {
                this.currentAttackerGO = this.dude2GO;
                this.currentAttacker = this.dude2;
                this.currentTarget = this.dude1;
                this.currentTargetGO = this.dude1GO;


            }

            else
            {
                this.currentAttackerGO = this.dude1GO;
                this.currentAttacker = this.dude1;
                this.currentTarget = this.dude2;
                this.currentTargetGO = this.dude2GO;
            }

            //non-blocking line of code

            this.refereeInstance.StartCoroutine(MoveObjectRoutine()); // coroutines are non blocking code because they live within their own threads
    }


    }


}
