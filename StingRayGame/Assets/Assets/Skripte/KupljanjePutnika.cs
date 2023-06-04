using UnityEngine;

public class KupljanjePutnika : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Putnik"))
            return;

        for (int i = 0; i < this.transform.childCount; i++)
            this.transform.GetChild(i).gameObject.GetComponent<Animator>().enabled = true;
    }
}