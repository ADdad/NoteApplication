using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NoteApplicationWPF.Tools
{
    internal interface IContentWindow
    {
        ContentControl ContentControl { get; }
    }
}
