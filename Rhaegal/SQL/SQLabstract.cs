using System;
using System.Collections.Generic;
using System.Data;
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
        public abstract void DeleteOperator(String Alias);
        public abstract void ModifyShift(string Shift, string Alias);
        public abstract void ModifyLocation(string Location, string Alias);
        public abstract void ModifyWorkstream(string Workstream, string Alias);
        public abstract void ModifyAlias(string OldAlias, string NewAlias);
        public abstract string[] PopAlias();
        public abstract string[] PopWorkStream();
        public abstract string[] PopShift();
        public abstract string[] PopLocation();


    }
}
