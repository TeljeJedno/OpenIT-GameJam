using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject riba;
    Vector2 pozicijaIgraca;

    void Start()
    {
        this.pozicijaIgraca = GameObject.FindGameObjectWithTag("Igrac").GetComponent<Igrac>().transform.position;
        StartCoroutine(StvarajRibu());
    }

    System.Collections.IEnumerator StvarajRibu()
    {
        while(true)
        {
            Instantiate(this.riba, new Vector3(this.pozicijaIgraca.x + 50.0f, Random.Range(0.0f, 100.0f)), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }
}