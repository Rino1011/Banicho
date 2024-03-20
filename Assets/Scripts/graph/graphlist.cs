using System.Collections.Generic;
using UnityEngine;

public class graphlist : MonoBehaviour
{
    public List<int> recentValues = new List<int>();
    public int maxValuesToKeep = 30;

    // �V�����l��ǉ����郁�\�b�h
    public void AddNewValue(int value)
    {
        recentValues.Add(value);
        // ���X�g�̃T�C�Y��maxValuesToKeep�𒴂����ꍇ�A�Â��l���폜����
        if (recentValues.Count > maxValuesToKeep)
        {
            recentValues.RemoveAt(0); // �擪�̒l���폜
        }
    }

    // Start���\�b�h�͗Ꭶ�̂��߂Ɏg���Ă��܂����A���ۂɂ͓K�؂ȃ^�C�~���O��AddNewValue���Ăяo���Ă�������
    void Start()
    {
        // ��F�����_���Ȓl��ǉ����Ă݂�
        for (int i = 0; i < 10; i++)
        {
            AddNewValue(Random.Range(0, 100)); // 0����99�͈̔͂̃����_���Ȑ�����ǉ�
        }
    }
}
