using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : PlayerAbility
{
    public override void UseAbility()
	{
		if(_turnTimer.IsNextTurn())
		{
			int damage = Random.Range(20,30);
			Debug.Log("ATTACK" + damage);
			_player.DealDamageToPlayer(damage);
			
		}
	}
}
