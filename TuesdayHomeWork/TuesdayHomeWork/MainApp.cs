namespace TuesdayHomeWork
{
    public delegate void GetTaskFunc();
    
    public class MainApp
    {        
        public static void Main(string[] args)
        {
            /*
            1. Define integer variables a and b.Read values a and b from Console and calculate: a + b, a - b, a* b, a/ b.Output obtained results.
            2. Output question “How are you ?“. Define string variable answer.Read the value answer and output: “You are (answer)".
            3. Read 3 variables of char type. Write message: “You enter (first char), (second char), (3 char)”
            4. Enter 2 integer numbers. Check if they are both positive – use bool expretion
            */
            GetTaskFunc deleg;
            deleg = HomeTask.GetTask1;
            deleg += HomeTask.GetTask2;
            deleg += HomeTask.GetTask3;
            deleg += HomeTask.GetTask4;
            deleg += HomeWork.GetHW1;
            deleg += HomeWork.GetHW2;
            deleg += HomeWork.GetHW3;

            deleg.Invoke();
        }
    }
}
