using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException()
        {
        }
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
