using UnityEngine;

public class DamageDealer2 : MonoBehaviour
{
    public int Damage = 1;

   private void OnTriggerEnter2D(Collider2D collider2D)
   {
    if(collider2D.gameObject.TryGetComponent<Health2>(out Health2 component))
    {
        component.TakeDamage(Damage);
    }
   }
}
