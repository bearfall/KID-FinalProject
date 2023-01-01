using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    Ray ray; //�g�u
    float raylength = 1.5f; //�g�u�̤j����
    RaycastHit hit; //�Q�g�u���쪺����
    // Start is called before the first frame update


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        //����v���g��O�e�����������g�u

        if (Physics.Raycast(ray, out hit, raylength))
        // (�g�u,out �Q�g�u���쪺����,�g�u����)�Aout hit �N��O�G��"�Q�g�u���쪺����"�a��hit
        {
            hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);
            //�V�Q�g�u���쪺����I�s�W��"HitByRaycast"����k�A���ݭn�Ǧ^��

            Debug.DrawLine(ray.origin, hit.point, Color.yellow);
            //��g�u���쪫��ɷ|�bScene�����e�X���u�A��K�d�\

            print(hit.transform.name);
            //�bConsole�����L�X�Q�g�u���쪺����W�١A��K�d�\                       
        }
        else
        {
        }
    }
}