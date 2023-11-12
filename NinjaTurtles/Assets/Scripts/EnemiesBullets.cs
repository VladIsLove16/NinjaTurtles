using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesBullets : MonoBehaviour
{
    //public float speed = 20f;
	public int damage = 40;
	//public Rigidbody2D rb;

	//void Start(){
	//	rb.velocity = transform.right * speed;
	//}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerHP playerHP = hitInfo.GetComponent<PlayerHP>();
		if (playerHP != null)
		{
			playerHP.TakeDamage(damage);
		}
		if(hitInfo.gameObject.tag != "Enemy"){
            Destroy(gameObject);
        }
        
	}
}
