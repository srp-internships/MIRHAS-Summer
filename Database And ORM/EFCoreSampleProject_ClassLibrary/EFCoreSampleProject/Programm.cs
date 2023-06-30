namespace EFCoreSampleProject
{
    public class Programm
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            var form = new Form1();
            form.ShowDialog();
        }
    }
}
