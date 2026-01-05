using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public GameObject collectEffect; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible"))
        {
            
            if (collectEffect != null)
            {
                
                Vector3 effectPos = collision.transform.position + new Vector3(0, 0.5f, 0);
                GameObject effect = Instantiate(collectEffect, effectPos, Quaternion.identity);

                
                Destroy(effect, 2f);
            }

           
            AudioSource audio = collision.GetComponent<AudioSource>();
            if (audio != null) audio.Play();

            
            Destroy(collision.gameObject, 1f);
        }
    }
}

