using UnityEngine;
namespace bearfall
{


    public class RunGhostTrigger : MonoBehaviour
    {

       
       
        [SerializeField, Header("�l�H����")]
        private GameObject badGhost;
        [SerializeField, Header("�l�H����ͦ��I")]
        private Transform spawnBadGhost;
        



        private void Start()
        {
            
        }
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
            
            Instantiate(badGhost, spawnBadGhost.position, spawnBadGhost.rotation);
          
            transform.GetComponent<Collider>().enabled = false;
        }
       

    }
}