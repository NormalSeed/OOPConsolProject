using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Items
{
    public interface IUsable
    {
        public string Name { get; set; }
        public void Use();
    }
}
