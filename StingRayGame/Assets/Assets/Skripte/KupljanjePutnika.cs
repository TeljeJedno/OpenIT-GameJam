using UnityEngine;

public class KupljanjePutnika : MonoBehaviour
{
    GameObject[] putnici;

    void Start() => this.putnici = GameObject.FindGameObjectsWithTag("Putnik");

    void OnTriggerEnter2D(Collider2D collision) => StartCoroutine(PokupiPutnike());

    System.Collections.IEnumerator PokupiPutnike()
    {
        foreach (GameObject putnik in this.putnici)
        {
            yield return new WaitForSeconds(1.0f);

            Destroy(putnik);
        }

        //Destroy(this.gameObject);
    }
}