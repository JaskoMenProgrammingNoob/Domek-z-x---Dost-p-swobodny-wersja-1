using System.IO;
using System.Security.Cryptography.X509Certificates;
class Domek
{
    FileStream F;

    public void zapisz_odczytaj_dane()
    {
        F = new FileStream("domek.txt", FileMode.Create);
       /* for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12 - i; j++)
            {
                if (j == 12 - i || j == 12)
                {
                    F.WriteByte((byte)'X');
                }
                else
                {
                    F.WriteByte((byte)' ');
                }
            } */
            //for (int g = 0; g < i * 2 - 12; g++)
            //{
                //if()
                //F.WriteByte((byte)'X');
            //}
            //F.WriteByte((byte)'\n');
        
        
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 13 - i; j++)
            {
                F.WriteByte((byte)' ');
            }
                for (int g = 0; g < i * 2 - 1; g++)
            {
                F.WriteByte((byte)'X');
            }
            F.WriteByte((byte)'\n');
        }
        for(int x = 0; x < 10; x++)
        {
            for (int y = 0; y <= 23; y++)
            {
                if (y == 1 || y == 23 || (x == 9 && y >= 1))
                {
                    F.WriteByte((byte)'X');
                }
                else
                {
                    F.WriteByte((byte)' ');
                }
            }
            F.WriteByte((byte)'\n');
        }
        F.Close(); 
        F = new FileStream("domek.txt", FileMode.Open);
        //F.Seek = (0, SeekOrigin.Begin);
    }

    static void Main(string[] args)
    {
        Domek domek = new Domek();
        domek.zapisz_odczytaj_dane();
    }

}