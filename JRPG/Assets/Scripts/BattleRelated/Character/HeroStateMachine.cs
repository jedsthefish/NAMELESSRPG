using UnityEngine;
using System.Collections;

public class HeroStateMachine : MonoBehaviour
{

    public BaseHero hero;

    public enum TurnState
    {
        Processing,
        AddtoList,
        Waiting,
        Selecting,
        Action,
        Dead
    }

    public TurnState currentState;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        switch (currentState)
        {

            case (TurnState.Processing):
                {

                    break;

                }

            case (TurnState.AddtoList):
                {

                    break;

                }
            case (TurnState.Waiting):
                {

                    break;

                }
            case (TurnState.Selecting):
                {

                    break;

                }
            case (TurnState.Action):
                {

                    break;

                }
            case (TurnState.Dead):
                {

                    break;

                }
                
        }

    }
}
