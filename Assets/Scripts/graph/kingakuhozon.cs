using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class kingakuhozon : MonoBehaviour
{
    private int[] clickCounts = new int[30];
    private float[] startTimes = new float[30];
    private float timeWindow = 5f; // �N���b�N���L���Ȏ��Ԙg�i�b�j
    private int currentIndex = 0;

    void Update()
    {
        // �}�E�X���N���b�N���ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            // ���݂̎���
            float currentTime = Time.time;

            // �V�������Ԙg���K�v���ǂ������`�F�b�N
            if (currentTime - startTimes[currentIndex] > timeWindow)
            {
                currentIndex = (currentIndex + 1) % 30; // ���̃C���f�b�N�X�ɐi�ށi30�𒴂�����ŏ��̗v�f�ɖ߂�j
                startTimes[currentIndex] = currentTime; // �V�������Ԙg�̊J�n������ݒ�
                clickCounts[currentIndex] = 0; // �N���b�N�񐔂����Z�b�g
            }

            // �ϐ����쐬���āA�N���b�N�񐔂��i�[
            int newVariable = clickCounts[currentIndex]+ nisuu.intValue;
            Debug.Log("Variable " + currentIndex + ": " + newVariable);
        }
    }
}