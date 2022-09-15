namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("table", "tablo");
            sozluk.Add("book", "kitap");
            Console.WriteLine(sozluk["table"]);// tablo
            foreach (var eleman in sozluk)
            {
                Console.WriteLine(eleman);
            }
            foreach (var eleman in sozluk)
            {
                Console.WriteLine(eleman.Key+" - "+eleman.Value);
            }

            try
            {
                string[] ogrenciler = new string[2];
                Console.WriteLine(ogrenciler[2]); // Burada try olmasaydı uygulama kapanacaktı.
            }
            catch
            {
                Console.WriteLine("HATA MEYDANA GELDİ!");
            }
            try
            {
                string ad = null;
                ad = ad.Trim(); //Null reference exception verecek normalde.
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata adı:"+ ex.Message);
            }
            try
            {
                string path = @"C:\abidik\gubidik.txt";
                string icerik = File.ReadAllText(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}