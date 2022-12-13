using System;

internal class BookingUpForBeauty
{
    public static void Main(string[] args)
    {
        // Task 1

        Helper.DisplayTask("I", "Parse appointment date");
        Helper.DisplayExample(
            "Appointment.Schedule(\"7/25/2019 13:45:00\")",
            new DateTime(2019, 7, 25, 13, 45, 0).ToString()
            );
        Console.WriteLine(Appointment.Schedule("7/25/2019 13:45:00"));
        Console.WriteLine();



        // Task 2
        Helper.DisplayTask("II", "Check if an appointment has already passed");
        Helper.DisplayExample(
            "Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0))",
            "True"
            );
        Console.WriteLine(Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));
        Console.WriteLine();



        // Task 3
        Helper.DisplayTask("III", "Check if appointment is in the afternoon");
        Helper.DisplayExample(
            "Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0))",
            "True"
            );
        Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
        Console.WriteLine();



        // Task 4
        Helper.DisplayTask("IV", "Describe the time and date of the appointment");
        Helper.DisplayExample(
            "Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0))",
            "You have an appointment on 3/29/2019 3:00:00 PM.");
        Console.WriteLine(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
        Console.WriteLine();



        // Task 5
        Helper.DisplayTask("V", "Return the anniversary date");
        Helper.DisplayExample(
            "Appointment.AnniversaryDate()",
            new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0).ToString()
            );
        Console.WriteLine(Appointment.AnniversaryDate());
        Console.WriteLine();
    }
}