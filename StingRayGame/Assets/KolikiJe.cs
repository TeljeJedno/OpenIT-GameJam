using UnityEngine;

public class KolikiJe : MonoBehaviour
{
    [SerializeField] GameObject igrac;
    bool sePovecao = false;

    void Update()
    {
        if (sePovecao)
            return;

        if (Vector2.Distance(this.transform.position, this.igrac.transform.position) > 12.0f)
            return;

        this.transform.localScale = new Vector3(10.0f, 10.0f, 10.0f);
        this.sePovecao = true;
    }
}