using UnityEngine;
namespace bearfall
{


    public class GhostTrigger : MonoBehaviour
    {
        [SerializeField, Header("����s��")]
        private GameObject ghostnumber;
        [SerializeField, Header("����ʧ@")]
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
                Animation.Play("����1");
                isGo = true
            } 


        }
    }
}