namespace QuizApplication
{
    public class FiftyFiftyJoker
    {
        private bool used;

        public FiftyFiftyJoker()
        {
            used = false;
        }

        public bool UseJoker()
        {
            if (!used)
            {
                used = true;
                return true;
            }
            return false;
        }

        public bool IsUsed()
        {
            return used;
        }
    }
}
