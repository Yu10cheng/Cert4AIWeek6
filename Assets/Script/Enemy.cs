using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private int _health = 100;
   [SerializeField] private int _maxHealth = 100;
   
   [SerializeField] private Bar _healthBar;
   
   public void Heal()
   {
	   
	   int heal = Random.Range(20,30);
	   // compare which one is smaller. then use that one for current health
	   _health = Mathf.Min(_health + heal, _maxHealth);
	   
	   UpdateHealthBar();
   }
   //DealDamage(20);
   public void DealDamage(int damage)
   {
	   _health = Mathf.Max(0, _health - damage);
	   UpdateHealthBar();
   }
   
   // int x = CurrentHealth();
   
   public int CurrentHealth()
   {
	   return _health;
   }
   
   public void UpdateHealthBar()
   {
	   _healthBar.SetBar((float) _health, (float) _maxHealth);
   }
}
