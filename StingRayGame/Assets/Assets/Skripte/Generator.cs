using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject riba;

    void Start() => StartCoroutine(StvarajRibu());

    System.Collections.IEnumerator StvarajRibu()
    {
        float xPozicijaIgraca = GameObject.FindGameObjectWithTag("Igrac").GetComponent<Igrac>().transform.position.x;
        while (true)
        {
            Instantiate(this.riba, new Vector3(xPozicijaIgraca + 50.0f, Random.Range(0.0f, 100.0f)), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }
}