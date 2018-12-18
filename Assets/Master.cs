using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        var enemy = CreateEntity(Tags.Enemy);
        enemy.transform.position = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private GameObject CreateEntity(string entityName)
    {
        return Instantiate(Resources.Load<GameObject>("prefabs/" + entityName));
    }
}
