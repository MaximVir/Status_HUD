namespace Rhaegal
{
    public abstract class SQLabstract
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\v-dychan\OneDrive - Microsoft\Rhaegal_v0.4\Rhaegal\Database.mdf';Integrated Security=True";
        public abstract void SetStatus(string Status, string Alias);
        public abstract string[] PostToBoard();
        public abstract int CheckExistance(string Alias);

    }
}
