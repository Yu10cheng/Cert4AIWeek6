using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
	
	public float timeSpeed = 0.5f;
	
	private bool _nextTurn = false;
	
	
	
	[SerializeField] private Bar _timeBar;
	
	public bool IsNextTurn() 
	{
		return _nextTurn;
	}
	
	public void ResetTimer()
	{
		_nextTurn = false;
		currentTime = 0;
	}
	void Update()
	{
		if(_nextTurn)
		{
			return;
		}
		
		
		currentTime += timeSpeed * Time.deltaTime;
		
		if(currentTime >= 1)
		{
			_nextTurn = true;
		}
		_timeBar.SetBar(currentTime,1);
	}
}
