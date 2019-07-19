namespace flower_shop {
    public class Tulip: IMothersDay {
        public string CommonName {get; set;}


        public string Color {get; set;}

        public int PetalCount {get; set;}

         public override string ToString() {

            return "A beauitful tulip"; 
    
        }
        public int Size {get; set;}
    }


}