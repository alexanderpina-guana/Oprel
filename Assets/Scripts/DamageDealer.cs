using UnityEngine;

public class DamageDealer : MonoBehaviour
{
   public float Damage = 1;

   private void OnTriggerEnter2D(Collider2D collider2D)
   {
    if(collider2D.gameObject.TryGetComponent<Health>(out Health component))
    {
        component.TakeDamage(Damage);
    }
   }
}