using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
   [SerializeField] private int _damagePlayer = 100;
   [SerializeField] private int _maxHealthPlayer = 100;
   
   [SerializeField] private Bar _healthBar;
   
   public void DealDamageToPlayer(int damage)
   {
	   _damagePlayer = Mathf.Max(0, _damagePlayer - damage);
	   UpdateHealthBarPlayer();
   }
   
   
   public void UpdateHealthBarPlayer()
   {
	   _healthBar.SetBar((float) _damagePlayer, (float) _maxHealthPlayer);
   }
}
