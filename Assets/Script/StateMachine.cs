using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
	public enum State
	{
		Normal,
		LowHp,
		Sleep
	}
	
	[SerializeField] private State _state;
	[SerializeField] private Enemy _enemy;
	[SerializeField] private Timer _turnTimer;	
	[SerializeField] private EnemyAttack _enemyA;
	
	//Start
	//----> NextState();
	//------->PatrolState();
	//------->ControlState();
	//------->SleepState();
	
	
    // Start is called before the first frame update
    private void Start()
    {
		NextState();
    }
	
	private void NextState()
	{
		switch (_state)
		{
			case State.Normal:
				StartCoroutine(NormalState());
				break;
			case State.LowHp:
				StartCoroutine(LowHpState());
				//do code stuff
				break;
			case State.Sleep:
				StartCoroutine(SleepState());
				break;
		}
	}
	
	private IEnumerator NormalState()
	{
		Debug.Log("Entering Normal State");
		
		while(_state == State.Normal)
		{
			if(!_turnTimer.IsNextTurn())
			{
				yield return null;	
				continue;
			}
			
			if(_enemy.CurrentHealth() < 30)
			{
				_state = State.LowHp;
			}
			yield return null; //continues 1 frame later
		}
		Debug.Log("Exiting Normal State");
		NextState();
	}
	
	private IEnumerator LowHpState()
	{
		Debug.Log("Entering LowHp State");	
		while(_state == State.LowHp)
		{
			if(!_turnTimer.IsNextTurn())
			{
				yield return null;	
				continue;
			}
			_enemy.Heal();
			_turnTimer.ResetTimer();
			_enemyA.UseAbility();
			
			if(_enemy.CurrentHealth() > 70)
			{
				_state = State.Normal;
			}
			//do code here
			yield return null;
		}
		//Do code
		Debug.Log("Exiting LowHp State");
		NextState();
	}
	
	private IEnumerator SleepState()
	{
		Debug.Log("Entering Sleep State");
		while(_state == State.Sleep)
		{
			//do code here
			yield return null;
		}
		//Do code
		Debug.Log("Exiting Sleep State");
		NextState();
	}

    // Update is called once per frame
    void Update()
    {
		
    }
}
