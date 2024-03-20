using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class saample : MonoBehaviour
{
    public  RectTransform m_rtView;
    private void Awake()
    {
        m_rtView = GetComponent<RectTransform>();
        CreateDot(new Vector2(200.0f, 200.0f));

        // ����30�����̃f�[�^�𐶐�����testData�ɑ��
        List<int> testData = GenerateLast30DaysData();

        ShowGraph(testData);
    }

    private List<int> GenerateLast30DaysData()
    {
        List<int> testData = new List<int>();

        // ��������30���O�܂ł̃f�[�^�𐶐����AtestData�ɒǉ�
        for (int i = 0; i < 30; i++)
        {
            // �����œK�؂ȃf�[�^�������@���������Ă�������
            // ���̗�ł́A���̃f�[�^�𐶐����Ă��܂����A���ۂ̃A�v���P�[�V�����ł͓K�؂ȃf�[�^�\�[�X����f�[�^���擾���Ă�������
            int data = GetDailyDataForDay(DateTime.Now.AddDays(-i));
            testData.Add(data);
        }

        return testData;
    }

    // ���t���Ƃ̃f�[�^���擾���郁�\�b�h�̗�
    private int GetDailyDataForDay(DateTime date)
    {
        // �����œK�؂ȃf�[�^�擾���@���������Ă�������
        // ���̗�ł́A���̃����_���ȃf�[�^�𐶐����Ă��܂����A���ۂ̃A�v���P�[�V�����ł̓f�[�^�x�[�X����f�[�^���擾����Ȃǂ̓K�؂ȕ��@���������Ă�������
        int data = button.nowmoney;
        return data;
    }




    private GameObject CreateDot(Vector2 _position)
    {
        GameObject objDot = new GameObject("dot", typeof(Image));
        objDot.GetComponent<Image>().color = new Color(0.3764706f, 0.3764706f, 0.3764706f, 1f); // RGBA�̒l���w�肵�Ă��܂��BA�̓A���t�@�l�i�����x�j�ŁA1f�͕s������\���܂��B
        objDot.transform.SetParent(m_rtView, false);
        RectTransform rtDot = objDot.GetComponent<RectTransform>();
        rtDot.anchoredPosition = _position;
        rtDot.sizeDelta = new Vector2(10.0f, 10.0f);
        rtDot.anchorMin = Vector2.zero;
        rtDot.anchorMax = Vector2.zero;
        return objDot;
    }

    private void ShowGraph(List<int> _dataList)
    {
        float fGraphHeight = m_rtView.sizeDelta.y;
        float fMaxY = 100.0f;
        float fPitchX = 50.0f;
        float fOffsetX = 30.0f;

        GameObject objLast = null;

        for (int i = 0; i < _dataList.Count; i++)
        {
            float fPosX = i * fPitchX + fOffsetX;
            float fPosY = (_dataList[i] / fMaxY) * fGraphHeight;
            GameObject objDot =  CreateDot(new Vector2(fPosX, fPosY));

            if (objLast != null)
            {
                CreateLine(
                    objLast.GetComponent<RectTransform>().anchoredPosition,
                    objDot.GetComponent<RectTransform>().anchoredPosition
                    );
            }

            objLast = objDot;
        }
    }

    private void CreateLine( Vector2 _pointA,Vector2 _pointB)
    {
        GameObject objLine = new GameObject("dotline", typeof(Image));
        
        objLine.transform.SetParent(m_rtView, false);

        RectTransform rtLine = objLine.GetComponent<RectTransform>();

        Vector2 dir = (_pointB - _pointA).normalized;
        float fDistance = Vector2.Distance(_pointA, _pointB);

        rtLine.anchorMin = Vector2.zero;
        rtLine.anchorMax = Vector2.zero;

        rtLine.sizeDelta = new Vector2(fDistance, 5.0f);
        rtLine.localEulerAngles = new Vector3(
            0.0f, 0.0f,
            Vector2.SignedAngle(new Vector2(1.0f, 0.0f), dir));

        rtLine.anchoredPosition = _pointA + dir * fDistance*0.5f;
    }
}
