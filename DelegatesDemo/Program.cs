printMsg printConsole = (String msg) =>
{
    Console.WriteLine(msg);
};

printMsg printFile = (String msg) =>
{
    File.AppendAllText("./myPath", msg);
};

printConsole("My msg for you, \"STAY FOCUSED\"");

delegate void printMsg(String msg);