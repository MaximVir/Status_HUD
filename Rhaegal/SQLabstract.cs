using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhaegal
{
    public abstract class SQLabstract
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\v-dychan\OneDrive - Microsoft\Rhaegal_v0.4\Rhaegal\Database.mdf';Integrated Security=True";
        public abstract void SetStatus(string Status, string Alias);
        public abstract void PostToBoard();

    }
}
