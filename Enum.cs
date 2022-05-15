using static System.Console;

namespace Enum
{
    class MainApp
    {
        enum DialogResult { YES=200, NO, CANCLE, CONFIRM, OK }

        static void Main(string[] args)
        {
            WriteLine((int)DialogResult.NO);
            WriteLine((int)DialogResult.YES);
            WriteLine((int)DialogResult.CANCLE);
            WriteLine((int)DialogResult.CONFIRM);
            WriteLine((int)DialogResult.OK);
        }
    }
}