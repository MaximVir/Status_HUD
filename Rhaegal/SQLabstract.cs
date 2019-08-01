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
        public abstract string[] PostToBoard();
        public abstract int CheckExistance(string Alias);
        public abstract void CreateOperator(string Alias, string Workstream, string Location, string Shift);
        public abstract void ModifyShift();
        public abstract void ModifyLocation();

        public abstract void ModifyWorkstream();

        public abstract string[] PopAlias();

    }
}
