using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnedBasedCombatStateMachine : MonoBehaviour {


    List<BaseCharacter> combatOrder = new List<BaseCharacter>();
        

    public enum BattleStates
    {
        Start,
        PlayerChoice,
        EnemyChoice, 
        Lose,
        Win

    }

    void OrderPlayers()
    {
        for(int i = 0; i < combatOrder.Count; i++)
        {
            for (int j = i; j < combatOrder.Count; j++)
            {
                if (combatOrder[i].Speed < combatOrder[j].Speed)
                {
                    var tempCharacter = combatOrder[j];
                    combatOrder[j] = combatOrder[i];
                    combatOrder[i] = tempCharacter;

                }
            }

        }
    }
    


    private BattleStates currentState;
    private BattleStateStart battleStateStartScript = new BattleStateStart();

    private bool hasAddedExperience;

	// Use this for initialization
	void Start () {
        currentState = BattleStates.Start;
        hasAddedExperience = false;
	
	}
	
	// Update is called once per frame
	void Update () {

        

        switch(currentState){
            case (BattleStates.Start):
                {


                    //setup battle things here

                    battleStateStartScript.PrepareForBattle();




                    break;
                }
            case (BattleStates.PlayerChoice):
                {
                    break;
                }
            case (BattleStates.EnemyChoice):
                {
                    break;
                }
            case (BattleStates.Lose):
                {
                    break;
                }
            case (BattleStates.Win):
                {
                    if (!hasAddedExperience)
                    {
                        IncreaseExperience.AddExperience();
                        hasAddedExperience = true;
                    }
                    break;
                }


               
        }

	}
}
