using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class SkiCoach : MonoBehaviour
{
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    public void Update()
    {
        StartCoroutine("Chase");
        
    }

    public void Chase()
    {
        GetComponent<NavMeshAgent>().destination = _player.transform.position;
    }

    /*private void OnTriggerEnter(Collider other)
    {

       if (other.tag == "Player")
       {
            StopCoroutine("Chase");
            Destroy(other.gameObject);
       }
        
    }*/
}
