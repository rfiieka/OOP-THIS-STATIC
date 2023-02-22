namespace App
{

    class Rumus
    {

        public double hasil;

        public static void tampil(){
            Console.WriteLine("program luas lingkaran");
        }

        public double set(int a){
            return  this.hasil = a * a * 3.14;
        }

        public void get(){
            Console.WriteLine(this.hasil);
        }
    }
}