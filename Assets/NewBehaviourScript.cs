using System.IO.Ports;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    private int maxvelo = 10;
    public int data;
    public string recebido;
    private Thread t1;

    SerialPort stream = new SerialPort("COM3", 9600);

    // Use this for initialization
    void Start()
    {
        t1 = new Thread(LeSerial);
        LeSerial();
        stream.Open();
        t1.Start();
    }
    // Update is called once per frame
    void Update()
    {
        if (maxvelo - data > 0)
        {
            rb.velocity = new Vector3(0, 0, maxvelo - data);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
    void LeSerial()
    {
        while (t1.IsAlive)
        {
            recebido = stream.ReadLine();
            data = int.Parse(recebido);
        }
    }
}
