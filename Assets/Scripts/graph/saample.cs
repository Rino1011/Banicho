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

        // 直近30日分のデータを生成してtestDataに代入
        List<int> testData = GenerateLast30DaysData();

        ShowGraph(testData);
    }

    private List<int> GenerateLast30DaysData()
    {
        List<int> testData = new List<int>();

        // 今日から30日前までのデータを生成し、testDataに追加
        for (int i = 0; i < 30; i++)
        {
            // ここで適切なデータ生成方法を実装してください
            // この例では、仮のデータを生成していますが、実際のアプリケーションでは適切なデータソースからデータを取得してください
            int data = GetDailyDataForDay(DateTime.Now.AddDays(-i));
            testData.Add(data);
        }

        return testData;
    }

    // 日付ごとのデータを取得するメソッドの例
    private int GetDailyDataForDay(DateTime date)
    {
        // ここで適切なデータ取得方法を実装してください
        // この例では、仮のランダムなデータを生成していますが、実際のアプリケーションではデータベースからデータを取得するなどの適切な方法を実装してください
        int data = button.nowmoney;
        return data;
    }




    private GameObject CreateDot(Vector2 _position)
    {
        GameObject objDot = new GameObject("dot", typeof(Image));
        objDot.GetComponent<Image>().color = new Color(0.3764706f, 0.3764706f, 0.3764706f, 1f); // RGBAの値を指定しています。Aはアルファ値（透明度）で、1fは不透明を表します。
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
