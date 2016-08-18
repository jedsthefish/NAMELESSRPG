using UnityEngine;
using System.Collections;

public class battleflow : MonoBehaviour {

    private string whoseTurn;


	// Use this for initialization
	void Start () {

        BattleStateStart battle = new BattleStateStart();
        battle.PrepareForBattle();




	
	}
	
	// Update is called once per frame
	void Update () {



	
	}
}
