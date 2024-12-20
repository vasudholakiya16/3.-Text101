using UnityEngine;


[CreateAssetMenu(menuName = "States")] // This will create a new asset in the project
public class States : ScriptableObject
{
  [TextArea(14,10)] [SerializeField] string storyText; // This will create a text area in the inspector for the story text to be entered in 
                                                       //the inspector  and will be displayed in the game view when the game is run 
                                                       // [SerializeField] States[] nextStates; // This will create an array of states that will be displayed in the inspector

    [SerializeField] States[] nextStates; // This will create an array of states that will be displayed in the inspector

    public string GetStateStory()
    {
        return storyText;
    }

    public States[] GetNextStates()
    {
        return nextStates;
    }
    // public States[] GetNextStates()
    // {
    //     return nextStates;
    // }
}
