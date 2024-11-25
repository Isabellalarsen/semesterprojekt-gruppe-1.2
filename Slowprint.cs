public class Print{
    // Method that takes text and delay as input
    // Prints each char, and has a delay of "delay" ms
    public static void SlowPrint(string text, int delay = 0) {
    foreach (char c in text) {
        Console.Write(c);
        Thread.Sleep(delay);
    }
    Console.WriteLine();
}
}
