using System;


public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        return new byte[reading];
    }
}
