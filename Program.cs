using jurnalModul5_103022330070;

class Program
{
    static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.DapatkanNilaiTerbesar(10, 30, 22);

        SimpleDataBase<int> dataSimpel = new SimpleDataBase<int>();
        dataSimpel.AddNewData(10);
        dataSimpel.PrintAllData();

    }
 
}