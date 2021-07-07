using static System.Console;


for (int index = 1; index < 4; index++)
{
    WriteLine($"Passing {index} gives {GetValue(index)}");
}

ReadLine();



static string GetValue(int value) 
    => 0 switch
    {
        _ when value == 1 => "Hello",
        _ when value == 2 => "World",
        _ => "NaN"
    };

#region Helper classes

/// <summary>
/// This class could also be in a separate class file
/// </summary>
internal static class Operations
{
    public static string GetValue(int value)
        => 0 switch
        {
            _ when value == 1 => "Hello",
            _ when value == 2 => "World",
            _ => "NaN"
        };
}

#endregion