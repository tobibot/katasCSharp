
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {

        // string format(int h, int m, int s) => System.String.Format($"{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}", h, m);
        string format(int h, int m, int s) => System.String.Format("{0:d2}:{1:d2}:{2:d2}", h, m, s);

        if (seconds <= 0 || seconds > 359999)
            return format(0, 0, 0);        

        var hours = seconds / (60 * 60);
        seconds -= hours * 60 * 60;

        var minutes = seconds / 60;
        seconds -= minutes * 60;

        return format(hours, minutes, seconds);        
    }
}
