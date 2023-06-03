using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject riba;
    Vector2 pozicijaIgraca;

    // Start is called before the first frame update
    void Start()
    {
        this.pozicijaIgraca = GameObject.FindGameObjectWithTag("Igrac").GetComponent<Igrac>().transform.position;
        StartCoroutine(StvarajRibu());
    }

    // Update is called once per frame
    void Update()
    {
        
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