using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerchao : MonoBehaviour
{
    public GameObject chao;
    public Transform player;
    private List<GameObject> pastchao = new List<GameObject>();
    private int zSpawn = 0;
    public int tamanho = 6;
    private int natela = 7;




    // Start is called before the first frame update
    void Start()
    {
        criachao();
        criachao();
    }

    public void criachao()
    {
        GameObject go = Instantiate(chao, new Vector3(1.4f, 0, chao.transform.position.z + zSpawn), chao.transform.rotation);
        pastchao.Add(go);
        zSpawn += tamanho;
    }
    // Update is called once per frame
    void Update()

    {
        if (player.position.z > zSpawn - (natela * tamanho))
        {
            criachao();
            if (player.position.z > pastchao[0].transform.position.z + 2 * tamanho)
            {
                Destroy(pastchao[0]);
                pastchao.RemoveAt(0);
            }
            else { }
        }
    }
}
