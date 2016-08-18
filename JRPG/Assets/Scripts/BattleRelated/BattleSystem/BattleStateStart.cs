using UnityEngine;
using System.Collections;

public class BattleStateStart {

	private  BaseEnemy newEnemy = new BaseEnemy();

    private float strengthModifer = 0.1f;
    private float intellectModifer = 0.1f;

    

    public void PrepareForBattle()
    {
        //THIS IS WHERE ALL INITIAL SET UP HAPPENS FOR THE BATTLE
        CreateNewEnemy();




    }

    private void CreateNewEnemy()
    {
        newEnemy.EnemyName = "Enemy";
        newEnemy.EnemyAttribute= BaseEnemy.Atrribute.fire;
    }


}
