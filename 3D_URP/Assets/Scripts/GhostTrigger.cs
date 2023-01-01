using UnityEngine;
namespace bearfall
{


    public class GhostTrigger : MonoBehaviour
    {

        [SerializeField, Header("����s��")]
        private GameObject ghost;
        [SerializeField, Header("�ʵe")]
        private Animator Animator;
        [SerializeField, Header("�n���ӷ�")]
        private AudioSource Aud;
        [SerializeField, Header("�n��")]
        private AudioClip Oop;




        private void Start()
        {
            Animator = ghost.GetComponent<Animator>();
            Aud = ghost.GetComponent<AudioSource>();
        }
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
            GoGhostGo();
            PlaySound(Oop);
            transform.GetComponent<Collider>().enabled = false;


        }
        public void PlaySound(AudioClip sound)
        {
            Aud.PlayOneShot(sound);
        }
        void GoGhostGo()
        {
                Animator.enabled = true;
           
        }

    }
}