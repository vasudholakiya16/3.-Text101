 using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] States startingState;


    States state;


    // How to create an array in C# :-
    //int[] oddNumbers = { 1, 3, 5, 7, 9 }; // This is an array of odd numbers
    //string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" }; // This is an array of days of the week

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

        //Basic info about array :- 

        // Debug.Log(oddNumbers[3]); // This will print the first element of the array to the console
      //  Debug.Log(daysOfWeek[5]); // This will print the sixth element of the array to the console
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates(); // This will get the next states from the current state

        if (Input.GetKeyDown(KeyCode.Alpha1)) // This will check if the key 1 is pressed
        {
            state = nextStates[0]; // This will set the state to the first element of the next states array
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // This will check if the key 2 is pressed
        {
            state = nextStates[1]; // This will set the state to the second element of the next states array
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // This will check if the key 3 is pressed
        {
            state = nextStates[2]; // This will set the state to the third element of the next states array
        }
        textComponent.text = state.GetStateStory(); // This will update the text component with the story text
    }
}
