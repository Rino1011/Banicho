using UnityEngine;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#elif UNITY_IOS
using Unity.Notifications.iOS;
#endif

public class sample2 : MonoBehaviour
{
    void Start()
    {
#if UNITY_ANDROID
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Default notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification()
        {
            Title = "�^�C�g������",
            Text = "�e�L�X�g����",
            FireTime = System.DateTime.Now.AddSeconds(10)
        };
        AndroidNotificationCenter.SendNotification(notification, "channel_id");
#elif UNITY_IOS
        var timeTrigger = new iOSNotificationTimeIntervalTrigger()
        {
            TimeInterval = new System.TimeSpan(0, 0, 0, 10),
            Repeats = false
        };

        var notification = new iOSNotification()
        {
            Identifier = "_notification_01",
            Title = "�^�C�g��",
            Body = "�{�f�B����",
            Subtitle = "�T�u�^�C�g��",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = timeTrigger,
        };
        iOSNotificationCenter.ScheduleNotification(notification);
#endif
    }

}