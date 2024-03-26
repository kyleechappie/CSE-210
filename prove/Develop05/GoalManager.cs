//eventually will have save and load...
using System.Drawing;
using System.IO;

public class GoalManager
{
    int Score = 0;

    public void addToScore(int pointValue){
        Score += pointValue;
    }

    public int getScore(){
        return Score;
    }


public void SaveGoals(List<Goal> ListOfGoals, string fileName)
    {
        using(StreamWriter writer = new StreamWriter(fileName)){
            //write one line for each goal in the list of goals
            foreach (Goal goal in ListOfGoals)
            {
                writer.WriteLine(goal.FormatGoal());
            }
        }
        
    }
    
}
