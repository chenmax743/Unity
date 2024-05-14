using UnityEngine;
public class Projectile : MonoBehaviour
{
   public GameObject explosion;
   
   void OnCollisionEnter(Collision other)
   {
       Instantiate(explosion,transform.position,transform.rotation);
       if (other.gameObject.CompareTag("Target"))
    {
        // 如果碰撞對象的標籤是 "Target"，則執行相應的操作
        Debug.Log("與目標碰撞了！");
    }
    
    // 在碰撞後銷毀投射物
    Destroy(gameObject);
   }
}
