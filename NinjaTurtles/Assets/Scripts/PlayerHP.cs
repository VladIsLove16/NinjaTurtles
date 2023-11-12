using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int health = 100;
    //public GameObject gObj;
    //public Animator plAnim;
    public bool Died = false;
   

	//public GameObject deathEffect;

	public void TakeDamage (int damage)
	{
        if(!Died)
        {
            health -= damage;
            //plAnim.SetTrigger("entDamage");
		
		    if (health <=0)
		    {
			    Die();
		    }
        }
		
	}
	
	void Die ()
	{
		if(!Died)
        {
            //plAnim.SetTrigger("PlayerDeath");
            Died = true;
            //Invoke("LScene", 3);
        }
		
	}

    void LScene(){
        SceneManager.LoadScene (0);
    }
}
