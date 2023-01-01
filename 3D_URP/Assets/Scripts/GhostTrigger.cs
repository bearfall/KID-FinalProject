using UnityEngine;
namespace bearfall
{


    public class GhostTrigger : MonoBehaviour
    {
        [SerializeField, Header("°­»î½s¸¹")]
        private GameObject ghostnumber;
        [SerializeField, Header("°­»î°Ê§@")]
        private Animation Animation;
        private bool isGo = false;

       
        private void OnTriggerEnter()
        {
            GoGhostGo();
        }

        void GoGhostGo()
        {
            ghostnumber = GetComponent<GameObject>();
            Animation = GetComponent<Animation>();
            if (isGo = false)
            {
                Animation.Play("°­»î1");
                isGo = true
            } 


        }
    }
}