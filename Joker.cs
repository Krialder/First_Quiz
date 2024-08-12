using System.Runtime.CompilerServices;

namespace QuizApplication
{
    public class RevealAnswer
    {
        private bool used;

        public RevealAnswer()
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
