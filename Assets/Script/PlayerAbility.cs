using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAbility : MonoBehaviour
{
    [SerializeField]
	protected Timer _turnTimer;
	[SerializeField]
	protected Enemy _enemy;
	[SerializeField]
	protected Player _player;
	
	public abstract void UseAbility();
	
	protected void EndTurn()
	{
		if(_turnTimer != null)
		{
			_turnTimer.ResetTimer();
		}

	}

	
}
