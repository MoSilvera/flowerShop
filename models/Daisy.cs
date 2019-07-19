namespace flower_shop {
    public class Daisy: IBirthday {
        public string CommonName {get; set;}

        public string Color {get; set;}

        public int PetalCount {get; set;}
        public override string ToString() {

            return "A beauitful Daisy"; 

        }
    }
         
        
}