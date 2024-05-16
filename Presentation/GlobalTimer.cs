using System;
using System.Windows.Forms; // Importa este espacio de nombres

public static class GlobalTimer
{
    private static System.Windows.Forms.Timer timer; // Especifica el Timer de Windows Forms

    public static event EventHandler Tick;

    public static void Start(int interval)
    {
        if (timer == null)
        {
            timer = new System.Windows.Forms.Timer(); // Crea una instancia del Timer de Windows Forms
            timer.Tick += Timer_Tick;
        }

        timer.Interval = interval;
        timer.Start();
    }

    public static void Stop()
    {
        if (timer != null)
        {
            timer.Stop();
        }
    }

    private static void Timer_Tick(object sender, EventArgs e)
    {
        Tick?.Invoke(sender, e);
    }
}
