using UnityEngine;
using System.Collections;

public class HubCtrl : MonoBehaviour
{

    public int Health { get; private set; }
    // Use this for initialization
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RemoveHealth(int hitPoints)
    {
        Health -= hitPoints;
    }
}
