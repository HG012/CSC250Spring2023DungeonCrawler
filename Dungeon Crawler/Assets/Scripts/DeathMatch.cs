using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMatch :
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dudde1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }

    public void D20Roll()
    {
        Random.Range(1, 21);
    }



    public void fight()
    {
        //goes back and forth
        //success means D20 rolls at least as high as AC
        //etc.

        this.dude1GO()
            {

            D20Roll()

            }
        this.dude2GO()
            {
            D20Roll
        }

        public void damageHealthDude1()
        {
            if (this.dude2GO(D20Roll >= this.dude1 ac; dude1 hp -dude1 attack))
        }
    else wait(1.50f)
    {
    this.dude1GO()
    {

        D20Roll()

            }
}

    public void damageHealthDude2()
        {
            if (this.dude1GO(D20Roll >= this.dude2 ac; dude2 hp - dude1 attack))
        }
    else wait(1.50f)
    {
    this.dude2GO()
            {

        D20Roll()

            }
}

    }



}
