using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�g���Ƃ��͖Y�ꂸ�ɁI
using UnityEngine.UI;

public class DamageSystem : MonoBehaviour
{

    //�ő�HP�A���[�Ȑ��ɂ���
    [SerializeField]
    int maxHP = 120;
    //���݂�HP
    [SerializeField]
    //public float currentHP;

    //public GameObject textObj;
    Text text;
    GameObject hpSystem;

    void Start()
    {
        //Text��GameObject�Ƃ��Ď擾����
        //textObj = GameObject.Find("Text");
        //HPSystem���擾����
        hpSystem = GameObject.Find("HPSystem");
    }

    void Update()
    {
        //Text��Text�R���|�[�l���g�ɃA�N�Z�X
        //(int)��float�𐮐��ŕ\�����邽�߂̂���
        //HPSystem�̃X�N���v�g��HPDown�֐���2�̐��l�𑗂�
        hpSystem.GetComponent<HPSystem>().HPDown(image_wariai.kekka2, maxHP);
    }

    //FixedUpdate�͈��ɌĂ΂��̂Ŏ����I�Ɏg�������ɗǂ��炵��
    void FixedUpdate()
    {
        //currentHP��0�ȏ�Ȃ�True
        if (0 <= image_wariai.kekka2)
        {
            //maxHP����b���i�~10�j������������currentHP
            //image_wariai.kekka2 = maxHP - Time.time * 10;
        }
    }
}
