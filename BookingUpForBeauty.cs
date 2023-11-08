using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription); 
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        string description = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");
        return "You have an appointment on " + description + ".";
    }

    public static DateTime AnniversaryDate()
    {
        int thisYear = DateTime.Now.Year;
       return new DateTime(thisYear, 9, 15, 0, 0, 0);
    }
}
