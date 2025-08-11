using UnityEngine;
public class ZomBehaviour : MonoBehaviour
{
    [SerializeField] GameObject effect;
    private int health = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            if (health == 0)
            {
                Instantiate(effect, transform.position, effect.transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                --health;
            }
        }
    }
}