namespace TaskBoardApp.Data
{
    public class DataConstants
    {
        public class Task
        {
            public const int TaskMinTitle = 5;
            public const int TaskMaxTitle = 70;

            public const int DescriptionMin = 10;
            public const int DescriptionMax = 1000;
        }
        public class Board
        {
            public const int BoardMaxName = 30;
            public const int BoardMinName = 3;
        }
    }
}
