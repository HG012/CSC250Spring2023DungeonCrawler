import java.util.Random;

public class WorkerBee extends Thread
{
    private Monster theMonster;

public WorkerBee(Monster theMonster)
{
    this.theMonster = theMonster;
}

//method overloading - we are redefining the run method to do something rather than nothing
public void run()
{
    Random r = new Random();
    String[] directions = { "north", "south", "east", "west" };
    int num;
    while (true)
    {
        num = r.nextInt(20) + 3;
        try
        {
            Thread.sleep(num * 100);

            //pick a random direction
            String direction = directions[r.nextInt(4)];

            //does my room have an exit in that direction?
            if (this.theMonster.getCurrentRoom().hasExit(direction))
            {
                if (this.theMonster.getCurrentRoom().getNumberOfPlayers() > 0)
                {
                    System.out.println(this.theMonster.getName() + " leaves to the " + direction);
                }
                this.theMonster.getCurrentRoom().takeExit(this.theMonster, direction);
            }

        }
        catch (InterruptedException e)
        {
            System.err.println("Whoops");
        }
    }

}
}